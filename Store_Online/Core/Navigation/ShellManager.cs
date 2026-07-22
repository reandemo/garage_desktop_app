using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Store_Online.Core.Navigation
{
    public sealed class ShellManager
    {
        private static readonly Lazy<ShellManager> _instance =
            new(() => new ShellManager());

        /// <summary>
        /// Singleton Instance
        /// </summary>
        public static ShellManager Instance => _instance.Value;

        private Frame? _mainFrame;

        private ShellManager()
        {
        }

        /// <summary>
        /// Initialize application shell.
        /// Call once from GarageMainWindow.
        /// </summary>
        /// <param name="frame"></param>
        public void Initialize(Frame frame)
        {
            _mainFrame = frame;
        }

        /// <summary>
        /// Navigate to page instance.
        /// </summary>
        public void Navigate(Page page)
        {
            if (_mainFrame == null)
                throw new InvalidOperationException(
                    "ShellManager has not been initialized.");

            _mainFrame.Navigate(page);
        }

        /// <summary>
        /// Navigate by page type.
        /// </summary>
        public void Navigate<T>()
            where T : Page, new()
        {
            Navigate(new T());
        }

        /// <summary>
        /// Can Go Back
        /// </summary>
        public bool CanGoBack =>
            _mainFrame?.CanGoBack ?? false;

        /// <summary>
        /// Can Go Forward
        /// </summary>
        public bool CanGoForward =>
            _mainFrame?.CanGoForward ?? false;

        /// <summary>
        /// Go Back
        /// </summary>
        public void GoBack()
        {
            if (CanGoBack)
                _mainFrame!.GoBack();
        }

        /// <summary>
        /// Go Forward
        /// </summary>
        public void GoForward()
        {
            if (CanGoForward)
                _mainFrame!.GoForward();
        }

        /// <summary>
        /// Refresh Current Page
        /// </summary>
        public void Refresh()
        {
            _mainFrame?.Refresh();
        }

        /// <summary>
        /// Current Page
        /// </summary>
        public Page? CurrentPage =>
            _mainFrame?.Content as Page;

        /// <summary>
        /// Main Frame
        /// </summary>
        public Frame? MainFrame => _mainFrame;
    }
}
