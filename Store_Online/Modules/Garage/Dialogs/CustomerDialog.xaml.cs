using System.Windows;
using Store_Online.Core.Services;
using Store_Online.Modules.Garage.Models;

namespace Store_Online.Modules.Garage.Dialogs
{
    public partial class CustomerDialog : Window
    {
        /// <summary>
        /// Customer being added or edited.
        /// </summary>
        public CustomerModel Customer { get; }

        //---------------------------------------------------------
        // New Customer
        //---------------------------------------------------------
        public CustomerDialog()
        {
            InitializeComponent();

            Customer = new CustomerModel();

            txtCode.Focus();
        }

        //---------------------------------------------------------
        // Edit Customer
        //---------------------------------------------------------
        public CustomerDialog(CustomerModel customer)
        {
            InitializeComponent();

            Customer = customer;

            txtCode.Text = customer.Code;
            txtName.Text = customer.Name;
            txtPhone.Text = customer.Phone;

            txtCode.Focus();
            txtCode.SelectAll();
        }

        //---------------------------------------------------------
        // Save
        //---------------------------------------------------------
        private void BtnSave_Click(
            object sender,
            RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                DialogService.Warning("Customer Code is required.");
                txtCode.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                DialogService.Warning("Customer Name is required.");
                txtName.Focus();
                return;
            }

            Customer.Code = txtCode.Text.Trim();
            Customer.Name = txtName.Text.Trim();
            Customer.Phone = txtPhone.Text.Trim();

#if DEBUG
            MessageBox.Show(
                $"Code : {Customer.Code}\n" +
                $"Name : {Customer.Name}\n" +
                $"Phone : {Customer.Phone}",
                "CustomerDialog");
#endif

            DialogResult = true;
            Close();
        }

        //---------------------------------------------------------
        // Cancel
        //---------------------------------------------------------
        private void BtnCancel_Click(
            object sender,
            RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}