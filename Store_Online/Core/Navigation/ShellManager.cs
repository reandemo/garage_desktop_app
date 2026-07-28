using System.Windows.Controls;

namespace Store_Online.Core.Navigation
{
    public sealed class ShellManager
    {
        private static readonly Lazy<ShellManager> _instance =
            new(() => new ShellManager());

        public static ShellManager Instance => _instance.Value;

        private Frame? _mainFrame;

        private ShellManager()
        {
        }

        public void Initialize(Frame frame)
        {
            ArgumentNullException.ThrowIfNull(frame);

            if (_mainFrame == frame)
                return;

            if (_mainFrame != null)
                throw new InvalidOperationException(
                    "ShellManager has already been initialized.");

            _mainFrame = frame;
        }

        public void Navigate(Page page)
        {
            if (_mainFrame == null)
                throw new InvalidOperationException(
                    "ShellManager has not been initialized.");

            ArgumentNullException.ThrowIfNull(page);

            if (_mainFrame.Content?.GetType() == page.GetType())
                return;

            _mainFrame.Navigate(page);
        }

        public void Navigate<T>()
            where T : Page, new()
        {
            Navigate(new T());
        }

        public void Navigate(Type pageType)
        {
            ArgumentNullException.ThrowIfNull(pageType);

            if (!typeof(Page).IsAssignableFrom(pageType))
                throw new ArgumentException(
                    $"{pageType.FullName} is not a Page.",
                    nameof(pageType));

            if (Activator.CreateInstance(pageType) is not Page page)
                throw new InvalidOperationException(
                    $"Unable to create page: {pageType.FullName}");

            Navigate(page);
        }

        public bool CanGoBack =>
            _mainFrame?.CanGoBack ?? false;

        public bool CanGoForward =>
            _mainFrame?.CanGoForward ?? false;

        public void GoBack()
        {
            if (CanGoBack)
                _mainFrame!.GoBack();
        }

        public void GoForward()
        {
            if (CanGoForward)
                _mainFrame!.GoForward();
        }

        public void Refresh()
        {
            _mainFrame?.Refresh();
        }

        public void ClearHistory()
        {
            if (_mainFrame == null)
                return;

            while (_mainFrame.CanGoBack)
                _mainFrame.RemoveBackEntry();
        }

        public void Reset()
        {
            if (_mainFrame == null)
                return;

            while (_mainFrame.CanGoBack)
            {
                _mainFrame.RemoveBackEntry();
            }

            _mainFrame.Content = null;
            _mainFrame = null;
        }

        public Page? CurrentPage =>
            _mainFrame?.Content as Page;

        public Frame? MainFrame => _mainFrame;
    }
}