using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

using Store_Online.Core.Logging;
using Store_Online.Core.Services;
using Store_Online.Modules.Garage.Dialogs;
using Store_Online.Modules.Garage.Models;
using Store_Online.Modules.Garage.ViewModels;

namespace Store_Online.Modules.Garage.Views
{
    public partial class CustomerPage : Page
    {
        private readonly CustomerViewModel _viewModel;

        public CustomerPage(CustomerViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;

            DataContext = _viewModel;
        }

        #region Refresh

        private void BtnRefresh_Click(
            object sender,
            RoutedEventArgs e)
        {
            _viewModel.Refresh();
        }

        #endregion

        #region New Customer

        private void BtnNewCustomer_Click(
            object sender,
            RoutedEventArgs e)
        {
            try
            {
                CustomerDialog dialog = new();

                Window? owner = Window.GetWindow(this);

                if (owner != null)
                {
                    dialog.Owner = owner;
                }

                if (dialog.ShowDialog() == true)
                {
                    if (_viewModel.Save(dialog.Customer))
                    {
                        DialogService.Information(
                            "Customer saved successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                FileLogger.Log(
                    "CustomerPage.NewCustomer",
                    ex);

                DialogService.Error(ex);
            }
        }

        #endregion

        #region Edit

        private void BtnEdit_Click(
            object sender,
            RoutedEventArgs e)
        {
            EditCustomer();
        }

        private void dgCustomer_MouseDoubleClick(
            object sender,
            MouseButtonEventArgs e)
        {
            EditCustomer();
        }

        private void EditCustomer()
        {
            try
            {
                if (_viewModel.SelectedCustomer == null)
                {
                    DialogService.Warning(
                        "Please select a customer.");

                    return;
                }

                CustomerModel model = new()
                {
                    CustomerId = _viewModel.SelectedCustomer.CustomerId,
                    Code = _viewModel.SelectedCustomer.Code,
                    Name = _viewModel.SelectedCustomer.Name,
                    Phone = _viewModel.SelectedCustomer.Phone
                };

                CustomerDialog dialog = new(model);

                Window? owner = Window.GetWindow(this);

                if (owner != null)
                {
                    dialog.Owner = owner;
                }

                if (dialog.ShowDialog() == true)
                {
                    if (_viewModel.Save(dialog.Customer))
                    {
                        DialogService.Information(
                            "Customer updated successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                FileLogger.Log(
                    "CustomerPage.EditCustomer",
                    ex);

                DialogService.Error(ex);
            }
        }

        #endregion

        #region Delete

        private void BtnDelete_Click(
            object sender,
            RoutedEventArgs e)
        {
            try
            {
                if (_viewModel.SelectedCustomer == null)
                {
                    DialogService.Warning(
                        "Please select a customer.");

                    return;
                }

                if (!DialogService.Confirm(
                    $"Delete customer '{_viewModel.SelectedCustomer.Name}' ?"))
                {
                    return;
                }

                if (_viewModel.Delete(
                    _viewModel.SelectedCustomer.CustomerId))
                {
                    DialogService.Information(
                        "Customer deleted successfully.");
                }
            }
            catch (Exception ex)
            {
                FileLogger.Log(
                    "CustomerPage.DeleteCustomer",
                    ex);

                DialogService.Error(ex);
            }
        }

        #endregion
    }
}