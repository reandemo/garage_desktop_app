using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Store_Online.Models;
using Store_Online.Modules.Garage.Models;
using Store_Online.Modules.Garage.Repositories;
using Store_Online.Shared.Services;

namespace Store_Online.Modules.Garage.Pages
{
    public partial class GarageCustomerRegistration : Page
    {
        private readonly CustomerRepository _customerRepository;

        public GarageCustomerRegistration(CustomerRepository customerRepository)
        {
            InitializeComponent();

            _customerRepository = customerRepository;

            InitializeForm();
        }

        private void InitializeForm()
        {
            btnSave.IsEnabled = true;
            btnUpdate.IsEnabled = false;

            rdoMale.IsChecked = true;
            cboStatus.SelectedIndex = 0;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                AlertService.ValidateInput(
                "Customer Name is required.");

                txtCustomerName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                AlertService.ValidateInput(
                "Phone Number is required.");

                txtPhone.Focus();
                return false;
            }

            if (!dtpDateOfBirth.SelectedDate.HasValue)
            {
                AlertService.ValidateInput(
                "Date of Birth is required.");

                dtpDateOfBirth.Focus();
                return false;
            }

            return true;
        }
        private CustomerModel BuildCustomerModel(string command)
        {
            return new CustomerModel
            {
                Command = command,
                BranchCode = AppSession.BranchCode,
                CustomerId = txtCustomerCode.Text.Trim(),
                CustomerName = txtCustomerName.Text.Trim(),
                Gender = rdoMale.IsChecked == true ? "Male" : "Female",
                DateOfBirth = dtpDateOfBirth.SelectedDate,
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Province = cboProvince.Text.Trim(),
                Status = (cboStatus.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "Active",
                Remark = txtRemark.Text.Trim(),
                CreatedBy = AppSession.Email.ToString()
            };
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                if (!ValidateInput())
                    return;

                CustomerModel customer = BuildCustomerModel("I");

                string customerId = _customerRepository.Save(customer);

                if (string.IsNullOrWhiteSpace(customerId))
                {
                    AlertService.Error(
                    "Unable to save customer.",
                    "Save Customer");

                    return;
                }

                txtCustomerCode.Text = customerId;

                AlertService.Success(
                $"Customer '{customerId}' has been saved successfully.",
                "Save Customer");

                btnSave.IsEnabled = false;
                btnUpdate.IsEnabled = true;
            }
            catch (Exception ex)
            {
                AlertService.Error(
                ex.Message,
                "Error");
            }
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!ValidateInput())
                    return;

                if (!AlertService.Confirm(
                "Do you want to update this customer?",
                "Confirm Update"))
                {
                    return;
                }

                CustomerModel customer = BuildCustomerModel("U");

                string customerId = _customerRepository.Save(customer);

                if (string.IsNullOrWhiteSpace(customerId))
                {
                    AlertService.Warning(
                    "Unable to update customer.",
                    "Update Customer");

                    return;
                }

                txtCustomerCode.Text = customerId;

                AlertService.Success(
                $"Customer '{customerId}' has been updated successfully.",
                "Update Customer");
            }
            catch (Exception ex)
            {
                AlertService.Error(
                ex.Message,
                "Error");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {


            txtCustomerCode.Clear();
            txtCustomerName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtRemark.Clear();

            rdoMale.IsChecked = true;

            cboProvince.SelectedIndex = -1;
            cboStatus.SelectedIndex = 0;

            dtpDateOfBirth.SelectedDate = null;

            btnSave.IsEnabled = true;
            btnUpdate.IsEnabled = false;

            txtCustomerName.Focus();

            if (!AlertService.Confirm("Do you want to delete this customer?"))
                return;

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService?.CanGoBack == true)
            {
                NavigationService.GoBack();
            }
        }
    }
}
