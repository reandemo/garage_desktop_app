using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using Store_Online.Modules.Garage.Models;
using Store_Online.Shared.Helpers;

namespace Store_Online.Modules.Garage.Pages
{
    public partial class GarageCustomer : Page
    {
        private readonly ObservableCollection<CustomerModel> _customers = new();
        private readonly ObservableCollection<CustomerModel> _filteredCustomers = new();

        public GarageCustomer()
        {
            InitializeComponent();

            Loaded += GarageCustomer_Loaded;

            txtSearch.TextChanged += txtSearch_TextChanged;
            cboFilterStatus.SelectionChanged += Filter_Changed;
            cboFilterProvince.SelectionChanged += Filter_Changed;

            pagination.PageChanged += Pagination_PageChanged;
        }

        private void GarageCustomer_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCustomers();
        }

        private void Pagination_PageChanged(object? sender, EventArgs e)
        {
            LoadCurrentPage();
        }

        private void LoadCustomers()
        {
            _customers.Clear();

            string[] names =
            {
                "John Smith",
                "Emily Johnson",
                "David Brown",
                "Michael Lee",
                "Sophia Wilson",
                "Daniel Taylor",
                "Olivia Martin",
                "James Anderson",
                "Emma Thomas",
                "William Jackson"
            };

            string[] provinces =
            {
                "Phnom Penh",
                "Siem Reap",
                "Battambang",
                "Kampot",
                "Kandal",
                "Takeo",
                "Prey Veng",
                "Kampong Cham"
            };

            string[] genders =
            {
                "Male",
                "Female"
            };

            string[] statuses =
            {
                "Active",
                "Inactive",
                "Pending"
            };

            var random = new Random();

            for (int i = 1; i <= 50; i++)
            {
                _customers.Add(new CustomerModel
                {
                    No = i,
                    CustomerId = $"CUS{i:0000}",
                    CustomerName = names[random.Next(names.Length)],
                    Gender = genders[random.Next(genders.Length)],
                    Phone = $"01{random.Next(10000000, 99999999)}",
                    Email = $"customer{i}@email.com",
                    Province = provinces[random.Next(provinces.Length)],
                    VehicleCount = random.Next(1, 6),
                    Status = statuses[random.Next(statuses.Length)]
                });
            }

            ApplyFilter();
        }

        private void ApplyFilter()
        {
            var query = _customers.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                string keyword = txtSearch.Text.Trim();

                query = query.Where(x =>
                    (x.CustomerId ?? string.Empty).Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    (x.CustomerName ?? string.Empty).Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    (x.Phone ?? string.Empty).Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    (x.Email ?? string.Empty).Contains(keyword, StringComparison.OrdinalIgnoreCase));
            }

            if (cboFilterStatus.SelectedItem is ComboBoxItem statusItem)
            {
                string status = statusItem.Content?.ToString() ?? string.Empty;

                if (!status.Equals("All Status", StringComparison.OrdinalIgnoreCase))
                {
                    query = query.Where(x =>
                        string.Equals(x.Status, status, StringComparison.OrdinalIgnoreCase));
                }
            }

            if (cboFilterProvince.SelectedItem is ComboBoxItem provinceItem)
            {
                string province = provinceItem.Content?.ToString() ?? string.Empty;

                if (!province.Equals("All Provinces", StringComparison.OrdinalIgnoreCase))
                {
                    query = query.Where(x =>
                        string.Equals(x.Province, province, StringComparison.OrdinalIgnoreCase));
                }
            }

            _filteredCustomers.Clear();

            foreach (var customer in query)
            {
                _filteredCustomers.Add(customer);
            }

            pagination.Pagination.CurrentPage = 1;

            LoadCurrentPage();
        }

        private void LoadCurrentPage()
        {
            pagination.SetTotalRecords(_filteredCustomers.Count);

            dgCustomer.ItemsSource = PaginationHelper.GetPage(
                _filteredCustomers,
                pagination.Pagination.CurrentPage,
                pagination.Pagination.PageSize);
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            ApplyFilter();
        }

        private void Filter_Changed(object sender, SelectionChangedEventArgs e)
        {
            ApplyFilter();
        }

        private void btnNewCustomer_Click(object sender, RoutedEventArgs e)
        {

            NavigationService?.Navigate(
            App.GetService<GarageCustomerRegistration>());
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            txtSearch.Clear();

            cboFilterStatus.SelectedIndex = 0;
            cboFilterProvince.SelectedIndex = 0;

            LoadCustomers();

            MessageBox.Show(
                "Customer list refreshed successfully.",
                "Garage Management System",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "Export to Excel will be implemented soon.",
                "Garage Management System",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }
    }
}
