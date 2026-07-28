namespace Store_Online.Authentication
{
    using System.Diagnostics;
    using System.Text.RegularExpressions;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using Store_Online.Core.Services;
    using Store_Online.MainForms;
    using Store_Online.Models;
    using Store_Online.Shared.Notifications;

    public partial class Login : Window
    {
        private readonly ApiService _apiService;

        private bool _isLoading;

        private bool _showPassword;

        [GeneratedRegex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")]
        private static partial Regex EmailRegex();

        public Login()
        {
            InitializeComponent();

            _apiService = App.GetService<ApiService>();

            Loaded += Login_Loaded;
        }

        private void Login_Loaded(object sender, RoutedEventArgs e)
        {
            txtUserlogin.Focus();
#if DEBUG
            txtUserlogin.Text = "garage@gmail.com";
            txtPassword.Password = "ABCabc123$$";
#endif
        }

        private void OpenMainForm()
        {
            Stopwatch sw = Stopwatch.StartNew();

            Window? window = AppSession.SystemCode.Trim().ToUpperInvariant() switch
            {
                "COFFEE" => new CoffeeMainWindow(),
                "GARAGE" => new GarageMainWindow(),
                _ => null
            };

            Debug.WriteLine($"Create Window : {sw.ElapsedMilliseconds} ms");

            if (window == null)
            {
                NotificationService.Error($"Unknown system: {AppSession.SystemCode}");
                return;
            }

            sw.Restart();

            window.Show();

            Debug.WriteLine($"Show Window : {sw.ElapsedMilliseconds} ms");

            Close();
        }

        private async Task<bool> ValidateLoginAsync(
            string email,
            string password)
        {
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

        private void SetLoading(bool loading)
        {
            _isLoading = loading;

            btnLogin.IsEnabled = !loading;
            txtUserlogin.IsEnabled = !loading;
            txtPassword.IsEnabled = !loading;
            txtPasswordVisible.IsEnabled = !loading;

            btnLogin.Content = loading
                ? "Signing In..."
                : "Login";

            Mouse.OverrideCursor = loading
                ? Cursors.Wait
                : null;
        }

        private async void Btn_login_Click(object sender, RoutedEventArgs e)
        {
            if (_isLoading)
                return;

            string email = txtUserlogin.Text.Trim();
            string password = txtPassword.Password.Trim();

            if (!await ValidateLoginAsync(email, password))
                return;

            try
            {
                SetLoading(true);

                ApiResponse<LoginResponse>? result =
                    await _apiService.LoginAsync<ApiResponse<LoginResponse>>(
                        email,
                        password);

                if (!result.Success ||
                    result.Data == null ||
                    result.Data.User == null)
                {
                    await Notifier.ShowAsync(
                        result.Message ?? "Login failed.",
                        NotificationType.Error);

                    txtPassword.Focus();
                    txtPassword.SelectAll();

                    return;
                }

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
                    ex.Message,
                    NotificationType.Error);
            }
            finally
            {
                SetLoading(false);
            }
        }

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

        private void PasswordIcon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _showPassword = !_showPassword;

            if (_showPassword)
            {
                txtPasswordVisible.Text = txtPassword.Password;

                txtPassword.Visibility = Visibility.Collapsed;
                txtPasswordVisible.Visibility = Visibility.Visible;

                MaterialDesignThemes.Wpf.TextFieldAssist.SetLeadingIcon(
                    txtPasswordVisible,
                    MaterialDesignThemes.Wpf.PackIconKind.LockOpen);

                txtPasswordVisible.Focus();
                txtPasswordVisible.CaretIndex = txtPasswordVisible.Text.Length;
            }
            else
            {
                txtPassword.Password = txtPasswordVisible.Text;

                txtPasswordVisible.Visibility = Visibility.Collapsed;
                txtPassword.Visibility = Visibility.Visible;

                MaterialDesignThemes.Wpf.TextFieldAssist.SetLeadingIcon(
                    txtPassword,
                    MaterialDesignThemes.Wpf.PackIconKind.Lock);

                txtPassword.Focus();
            }
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!_showPassword)
            {
                txtPasswordVisible.Text = txtPassword.Password;
            }
        }

        private void txtPasswordVisible_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_showPassword)
            {
                txtPassword.Password = txtPasswordVisible.Text;
            }
        }
    }
}
