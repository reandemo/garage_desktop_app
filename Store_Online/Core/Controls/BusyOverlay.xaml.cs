using System;
using System.Windows;
using System.Windows.Controls;
using Store_Online.Core.Services;

namespace Store_Online.Core.Controls
{
    public partial class BusyOverlay : UserControl
    {
        public BusyOverlay()
        {
            InitializeComponent();

            BusyService.Instance.BusyStateChanged += OnBusyChanged;
        }

        private void OnBusyChanged(
            object? sender,
            bool isBusy)
        {
            Dispatcher.Invoke(() =>
            {
                Visibility =
                    isBusy
                        ? Visibility.Visible
                        : Visibility.Collapsed;
            });
        }
    }
}