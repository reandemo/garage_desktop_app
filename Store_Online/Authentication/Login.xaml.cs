using Store_Online.Core.Services;
using Store_Online.MainForms;
using Store_Online.Models;
using Store_Online.Shared.Notifications;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace Store_Online.Authentication
{
    public partial class Login : Window
    {
        private readonly ApiService _apiService = new();
        private bool _isLoading;

        [GeneratedRegex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")]
        private static partial Regex EmailRegex();

        public Login()
        {
            InitializeComponent();

            Loaded += (_, _) => txtUserlogin.Focus();

#if DEBUG
            // Demo account
            txtUserlogin.Text = "garage@gmail.com";
            txtPassword.Password = "ABCabc123$$";
#endif
        }

        #region Navigation

        private void OpenMainForm()
        {
            Window? mainWindow = AppSession.SystemCode.Trim().ToUpperInvariant() switch
            {
                "COFFEE" => new CoffeeMainWindow(),
                "GARAGE" => new GarageMainWindow(),
                _ => null
            };

            if (mainWindow == null)
            {
                NotificationService.Error($"Unknown system: {AppSession.SystemCode}");
                return;
            }

            mainWindow.Show();
            Close();
        }

        #endregion

        #region Validation

        private async Task<bool> ValidateLoginAsync()
        {
            string email = txtUserlogin.Text.Trim();
            string password = txtPassword.Password.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                await Notifier.ShowAsync(
                    "Please enter your email.",
                    NotificationType.Warning);

                txtUserlogin.Focus();
                return false;
            }

            if (!EmailRegex().IsMatch(email))
            {
                await Notifier.ShowAsync(
                    "Please enter a valid email address.",
                    NotificationType.Warning);

                txtUserlogin.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                await Notifier.ShowAsync(
                    "Please enter your password.",
                    NotificationType.Warning);

                txtPassword.Focus();
                return false;
            }

            if (password.Length < 5)
            {
                await Notifier.ShowAsync(
                    "Password must be at least 5 characters.",
                    NotificationType.Warning);

                txtPassword.Focus();
                return false;
            }

            return true;
        }

        #endregion

        #region Login

        private async void Btn_login_Click(object sender, RoutedEventArgs e)
        {
            if (_isLoading)
            {
                return;
            }

            if (!await ValidateLoginAsync())
            {
                return;
            }

            try
            {
                _isLoading = true;

                btnLogin.IsEnabled = false;
                txtUserlogin.IsEnabled = false;
                txtPassword.IsEnabled = false;

                btnLogin.Content = "Signing In...";
                Mouse.OverrideCursor = Cursors.Wait;

                string email = txtUserlogin.Text.Trim();
                string password = txtPassword.Password.Trim();

                var result = await _apiService.LoginAsync<ApiResponse<LoginResponse>>(
                    email,
                    password);

                if (!result.Success || result.Data == null || result.Data.User == null)
                {
                    await Notifier.ShowAsync(
                        result.Message ?? "Login failed.",
                        NotificationType.Error);

                    txtPassword.Focus();
                    txtPassword.SelectAll();

                    return;
                }

                // Save Session
                AppSession.Token = result.Data.Token;
                AppSession.UserId = result.Data.User.Id;
                AppSession.Email = result.Data.User.Email ?? string.Empty;
                AppSession.BranchCode = result.Data.Branch?.Branchcode ?? string.Empty;
                AppSession.SystemCode = result.Data.Branch?.System_id ?? string.Empty;
                AppSession.FullName = result.Data.User.Name ?? string.Empty;
                AppSession.RoleName = result.Data.User.Role?.Name ?? string.Empty;
                AppSession.Avatar = result.Data.User.Avatar ?? string.Empty;

                NotificationService.Success(
                    result.Message ?? "Login successful.");

                OpenMainForm();
            }
            catch (Exception ex)
            {
                await Notifier.ShowAsync(
                    $"Unable to login.\n{ex.Message}",
                    NotificationType.Error);
            }
            finally
            {
                _isLoading = false;

                btnLogin.IsEnabled = true;
                txtUserlogin.IsEnabled = true;
                txtPassword.IsEnabled = true;

                btnLogin.Content = "Login";

                Mouse.OverrideCursor = null;
            }
        }

        #endregion

        #region Events

        private void Btn_setupstore_Click(object sender, RoutedEventArgs e)
        {
            new StoreSetup().ShowDialog();
        }

        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Btn_login_Click(sender, e);
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        #endregion
    }
}