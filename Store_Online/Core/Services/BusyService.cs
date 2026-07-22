using System;

namespace Store_Online.Core.Services
{
    /// <summary>
    /// Provides a centralized busy/loading state for the application.
    /// </summary>
    public sealed class BusyService
    {
        private static readonly Lazy<BusyService> _instance =
            new(() => new BusyService());

        public static BusyService Instance => _instance.Value;

        private bool _isBusy;

        /// <summary>
        /// Gets whether the application is busy.
        /// </summary>
        public bool IsBusy => _isBusy;

        /// <summary>
        /// Raised whenever the busy state changes.
        /// </summary>
        public event EventHandler<bool>? BusyStateChanged;

        private BusyService()
        {
        }

        /// <summary>
        /// Show busy indicator.
        /// </summary>
        public void Show()
        {
            SetBusy(true);
        }

        /// <summary>
        /// Hide busy indicator.
        /// </summary>
        public void Hide()
        {
            SetBusy(false);
        }

        /// <summary>
        /// Set busy state.
        /// </summary>
        public void SetBusy(bool busy)
        {
            if (_isBusy == busy)
                return;

            _isBusy = busy;

            BusyStateChanged?.Invoke(this, _isBusy);
        }
    }
}