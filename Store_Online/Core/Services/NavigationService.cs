using System;
using System.Windows.Controls;
using Microsoft.Extensions.DependencyInjection;

namespace Store_Online.Core.Services
{
    public sealed class NavigationService
    {
        private static readonly Lazy<NavigationService> _instance =
            new(() => new NavigationService());

        public static NavigationService Instance =>
            _instance.Value;

        private object? _currentView;

        public object? CurrentView
        {
            get => _currentView;
            private set
            {
                _currentView = value;
                CurrentViewChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler? CurrentViewChanged;

        private NavigationService()
        {
        }

        //---------------------------------------------------------
        // MVVM Navigation
        //---------------------------------------------------------

        public void Navigate(object view)
        {
            ArgumentNullException.ThrowIfNull(view);

            CurrentView = view;
        }

        //---------------------------------------------------------
        // Frame Navigation
        //---------------------------------------------------------

        public void Navigate(Frame frame, Page page)
        {
            ArgumentNullException.ThrowIfNull(frame);
            ArgumentNullException.ThrowIfNull(page);

            frame.Navigate(page);
        }

        public void Navigate<TPage>(Frame frame)
            where TPage : Page
        {
            ArgumentNullException.ThrowIfNull(frame);

            TPage page =
                App.Services.GetRequiredService<TPage>();

            frame.Navigate(page);
        }

        public void GoBack(Frame frame)
        {
            ArgumentNullException.ThrowIfNull(frame);

            if (frame.CanGoBack)
            {
                frame.GoBack();
            }
        }

        public void GoForward(Frame frame)
        {
            ArgumentNullException.ThrowIfNull(frame);

            if (frame.CanGoForward)
            {
                frame.GoForward();
            }
        }

        public void Refresh(Frame frame)
        {
            ArgumentNullException.ThrowIfNull(frame);

            frame.Refresh();
        }
    }
}