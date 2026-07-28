using Store_Online.Authentication;
using Store_Online.Core.Navigation;
using Store_Online.Models;
using Store_Online.Modules.Garage.Pages;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace Store_Online.MainForms;

public partial class GarageMainWindow : Window
{
    private readonly Dictionary<string, Type> _routes = new();

    public GarageMainWindow()
    {
        Stopwatch sw = Stopwatch.StartNew();

        InitializeComponent();
        Debug.WriteLine($"InitializeComponent : {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        InitializeNavigation();
        Debug.WriteLine($"InitializeNavigation : {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        RegisterRoutes();
        Debug.WriteLine($"RegisterRoutes : {sw.ElapsedMilliseconds} ms");

        HookEvents();

        sw.Restart();
        ShellManager.Instance.Navigate<GarageDashboard>();
        Debug.WriteLine($"Navigate Dashboard : {sw.ElapsedMilliseconds} ms");

        Closed += GarageMainWindow_Closed;
    }

    private void HookEvents()
    {
        TopMenu.MenuClicked += TopMenu_MenuClicked;
        Header.LogoutRequested += Header_LogoutRequested;
    }

    private void GarageMainWindow_Closed(object? sender, EventArgs e)
    {
        TopMenu.MenuClicked -= TopMenu_MenuClicked;
        Header.LogoutRequested -= Header_LogoutRequested;
    }

    private void Header_LogoutRequested(object? sender, EventArgs e)
    {
        Logout();
    }

    private void Logout()
    {
        AppSession.Clear();

        ShellManager.Instance.Reset();

        Login login = new();

        Application.Current.MainWindow = login;

        login.Show();

        Close();
    }

    private void TopMenu_MenuClicked(object? sender, string menu)
    {
        if (!_routes.TryGetValue(menu, out Type? pageType))
        {
            MessageBox.Show(
                $"{menu} page has not been implemented yet.",
                "Navigation",
                MessageBoxButton.OK,
                MessageBoxImage.Information);

            return;
        }

        if (Activator.CreateInstance(pageType) is Page page)
        {
            ShellManager.Instance.Navigate(page);
        }
    }

    private void InitializeNavigation()
    {
        ShellManager.Instance.Initialize(MainContent);
    }

    private void RegisterRoutes()
    {
        _routes["Dashboard"] = typeof(GarageDashboard);

        // Garage
        _routes["Vehicles"] = typeof(VehiclePage);
        _routes["Customers"] = typeof(GarageCustomer);

        // _routes["VehicleBrands"] = typeof(VehicleBrandPage);
        // _routes["VehicleModels"] = typeof(VehicleModelPage);
        // _routes["VehicleColors"] = typeof(VehicleColorPage);
        // _routes["TransmissionTypes"] = typeof(TransmissionTypePage);
        // _routes["FuelTypes"] = typeof(FuelTypePage);
        // _routes["ServiceCategories"] = typeof(ServiceCategoryPage);
        // _routes["Technicians"] = typeof(TechnicianPage);

        // Inventory
        // _routes["Products"] = typeof(ProductPage);
        // _routes["ProductCategories"] = typeof(ProductCategoryPage);
        // _routes["Suppliers"] = typeof(SupplierPage);

        // Sales
        // _routes["Quotation"] = typeof(QuotationPage);
        // _routes["Invoice"] = typeof(InvoicePage);

        // Purchase
        // _routes["PurchaseOrder"] = typeof(PurchaseOrderPage);

        // Administration
        // _routes["Users"] = typeof(UserPage);
        // _routes["Roles"] = typeof(RolePage);
    }
}