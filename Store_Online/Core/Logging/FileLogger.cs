using Microsoft.Data.SqlClient;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Store_Online.Core.Logging
{
    public static class FileLogger
    {
        private static readonly object LockObject = new();

        private static readonly string LogFolder =
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "_Logs");

        private static string LogFile =>
            Path.Combine(
                LogFolder,
                $"Error_{DateTime.Now:yyyy-MM-dd}.log");

        #region Exception

        public static void Log(Exception ex)
        {
            Log("Application", ex, null, null);
        }

        public static void Log(
            string title,
            Exception ex)
        {
            Log(title, ex, null, null);
        }

        public static void Log(
            string title,
            Exception ex,
            string? sql,
            SqlParameter[]? parameters)
        {
            if (ex == null)
                return;

            try
            {
                lock (LockObject)
                {
                    Directory.CreateDirectory(LogFolder);

                    using StreamWriter writer = new(
                        LogFile,
                        true,
                        new UTF8Encoding(false));

                    WriteHeader(writer, title);

                    if (!string.IsNullOrWhiteSpace(sql))
                    {
                        writer.WriteLine("SQL");
                        writer.WriteLine(new string('-', 80));
                        writer.WriteLine(sql);
                        writer.WriteLine();
                    }

                    if (parameters is { Length: > 0 })
                    {
                        writer.WriteLine("Parameters");
                        writer.WriteLine(new string('-', 80));

                        foreach (SqlParameter p in parameters)
                        {
                            writer.WriteLine(
                                $"{p.ParameterName} = {p.Value}");
                        }

                        writer.WriteLine();
                    }

                    int level = 0;
                    Exception? current = ex;

                    while (current != null)
                    {
                        writer.WriteLine($"Type            : {current.GetType().FullName}");
                        writer.WriteLine($"Message         : {current.Message}");
                        writer.WriteLine($"Source          : {current.Source}");
                        writer.WriteLine($"TargetSite      : {current.TargetSite}");
                        writer.WriteLine();
                        writer.WriteLine("StackTrace");
                        writer.WriteLine(current.StackTrace);
                        writer.WriteLine();

                        current = current.InnerException;
                        level++;
                    }

                    writer.WriteLine();
                }
            }
            catch
            {
                // Logger should never throw.
            }
        }

        #endregion

        #region Message

        public static void Log(
            string title,
            string message)
        {
            try
            {
                lock (LockObject)
                {
                    Directory.CreateDirectory(LogFolder);

                    using StreamWriter writer = new(
                        LogFile,
                        true,
                        new UTF8Encoding(false));

                    WriteHeader(writer, title);

                    writer.WriteLine(message);
                    writer.WriteLine();
                }
            }
            catch
            {
            }
        }

        #endregion

        #region Header

        private static void WriteHeader(
     StreamWriter writer,
     string title)
        {
            writer.WriteLine(new string('=', 100));

            writer.WriteLine($"Date/Time        : {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            writer.WriteLine();

            writer.WriteLine($"Application      : {Process.GetCurrentProcess().ProcessName}");
            writer.WriteLine();

            writer.WriteLine($"Machine Name     : {Environment.MachineName}");
            writer.WriteLine($"Windows User     : {Environment.UserName}");
            writer.WriteLine();

            writer.WriteLine($"Working Folder   : {AppDomain.CurrentDomain.BaseDirectory}");
            writer.WriteLine();

            writer.WriteLine($"Title            : {title}");
            writer.WriteLine();
        }

        #endregion
    }
}