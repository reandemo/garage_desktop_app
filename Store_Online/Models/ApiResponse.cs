using System;

namespace Store_Online.Models
{
    public static class AppSession
    {
        public static string Token { get; set; } = string.Empty;
        public static int UserId { get; set; }

        public static string Email { get; set; } = string.Empty;

        public static string BranchCode { get; set; } = string.Empty;
        public static string BranchName { get; set; } = string.Empty;

        public static string SystemCode { get; set; } = string.Empty;

        public static string FullName { get; set; } = string.Empty;
        public static string RoleName { get; set; } = string.Empty;
        public static string Avatar { get; set; } = string.Empty;

        public static bool IsLoggedIn =>
            !string.IsNullOrWhiteSpace(Token);

        public static void Clear()
        {
            Token = string.Empty;
            UserId = 0;

            Email = string.Empty;

            BranchCode = string.Empty;
            BranchName = string.Empty;

            SystemCode = string.Empty;

            FullName = string.Empty;
            RoleName = string.Empty;
            Avatar = string.Empty;
        }

        public static void Load(LoginResponse? login)
        {
            if (login == null)
            {
                Clear();
                return;
            }

            Token = login.Token ?? string.Empty;

            UserId = login.User?.Id ?? 0;

            Email = login.User?.Email ?? string.Empty;

            FullName = login.User?.Name ?? string.Empty;

            RoleName =
                login.User?.Role?.Name
                ?? login.User?.Profile_Id
                ?? "User";

            Avatar = login.User?.Avatar ?? string.Empty;

            BranchCode = login.Branch?.Branchcode ?? string.Empty;

            BranchName = login.Branch?.Branch_name ?? string.Empty;

            SystemCode = login.Branch?.System_id ?? string.Empty;
        }
    }

    public class ApiResponse<T>
    {
        public bool Success { get; set; }

        public string? Message { get; set; } = string.Empty;

        public int StatusCode { get; set; }

        public T? Data { get; set; }
    }

    public class SystemInfo
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Inputter { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;
    }

    public class LoginResponse
    {
        public string Token { get; set; } = string.Empty;

        public UserInfo? User { get; set; }

        public BranchInfo? Branch { get; set; }
    }

    public class BranchInfo
    {
        public string? Branchcode { get; set; }

        public string? Branch_name { get; set; }

        public string? System_id { get; set; }
    }

    public class RoleInfo
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Code { get; set; }
    }

    public class UserInfo
    {
        public int Id { get; set; }

        public string? User_Id { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? BranchCode { get; set; }

        public string? Profile_Id { get; set; }

        public string? Avatar { get; set; }

        public RoleInfo? Role { get; set; }
    }
}