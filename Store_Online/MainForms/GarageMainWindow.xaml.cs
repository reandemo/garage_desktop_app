using Store_Online.Core.Navigation;
using Store_Online.Modules.Garage.Pages;
using System.Windows;

namespace Store_Online.MainForms;

public partial class GarageMainWindow : Window
{

    private readonly Dictionary<string, Type> _routes = new();

    public GarageMainWindow()
    {
        InitializeComponent();

        InitializeNavigation();

        RegisterRoutes();

        TopMenu.MenuClicked += TopMenu_MenuClicked;

        ShellManager.Instance.Navigate<GarageDashboard>();


    }
    private void TopMenu_MenuClicked(object? sender, string menu)
    {
        if (!_routes.TryGetValue(menu, out var pageType))
        {
            MessageBox.Show(
                $"{menu} page has not been implemented yet.",
                "Navigation",
                MessageBoxButton.OK,
                MessageBoxImage.Information);

            return;
        }

        if (Activator.CreateInstance(pageType) is System.Windows.Controls.Page page)
        {
            ShellManager.Instance.Navigate(page);
        }
    }
    private void InitializeNavigation()
    {
        ShellManager.Instance.Initialize(MainContent);
    }

    /// <summary>
    /// Register all application pages
    /// </summary>
    private void RegisterRoutes()
    {
        _routes["Dashboard"] = typeof(GarageDashboard);

        // Garage
        _routes["Vehicles"] = typeof(VehiclePage);
        // _routes["Customers"] = typeof(CustomerPage);

        //_routes["VehicleBrands"] = typeof(VehicleBrandPage);
        //_routes["VehicleModels"] = typeof(VehicleModelPage);
        //_routes["VehicleColors"] = typeof(VehicleColorPage);
        //_routes["TransmissionTypes"] = typeof(TransmissionTypePage);
        //_routes["FuelTypes"] = typeof(FuelTypePage);
        //_routes["ServiceCategories"] = typeof(ServiceCategoryPage);
        //_routes["Technicians"] = typeof(TechnicianPage);

        // Inventory
        //_routes["Products"] = typeof(ProductPage);
        //_routes["ProductCategories"] = typeof(ProductCategoryPage);
        //_routes["Suppliers"] = typeof(SupplierPage);

        // Sales
        //_routes["Quotation"] = typeof(QuotationPage);
        //_routes["Invoice"] = typeof(InvoicePage);

        // Purchase
        //_routes["PurchaseOrder"] = typeof(PurchaseOrderPage);

        // Administration
        //_routes["Users"] = typeof(UserPage);
        //_routes["Roles"] = typeof(RolePage);
    }

}
