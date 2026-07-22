using System.Windows;
using System.Windows.Controls;
using Store_Online.Core.Services;
using Store_Online.Models;

namespace Store_Online.Views
{
    /// <summary>
    /// Interaction logic for UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        ApiService api = new ApiService();

        public UsersPage()
        {
            InitializeComponent();
            api.Token = AppSession.Token;

        }
        private async Task LoadBranches()
        {
            ApiService api = new ApiService();

            api.Token = AppSession.Token;

            var branches =
                await api.GetAsync<List<BranchModel>>(
                    "branches");
            cboBranch.ItemsSource = branches;
        }
        private async Task LoadProfiles()
        {
            ApiService api = new ApiService();

            api.Token = AppSession.Token;

            var profiles =
                await api.GetAsync<List<ProfileModel>>(
                    "profiles");

            cboProfile.ItemsSource = profiles;
        }

        private async Task LoadUsers()
        {
            ApiService api = new ApiService();

            api.Token = AppSession.Token;

            var users =
                await api.GetAsync<List<UserModel>>(
                    "users");

            dgUsers.ItemsSource = users;
        }

        private async void Page_Loaded(
    object sender,
    RoutedEventArgs e)
        {
            await LoadBranches();
            await LoadProfiles();
            await LoadUsers();
        }

        private async void btnSave_Click(
     object sender,
     RoutedEventArgs e)
        {
            try
            {
                btnSave.IsEnabled = false;

                ApiService api = new ApiService();

                api.Token = AppSession.Token;

                var request =
                    new CreateUserRequest
                    {
                        Username =
                            txtUserLogin.Text,

                        Password =
                            txtPassword.Password,

                        BranchId =
                            Convert.ToInt32(
                                cboBranch.SelectedValue),

                        ProfileId =
                            Convert.ToInt32(
                                cboProfile.SelectedValue)
                    };

                var result =
                    await api.PostAsync<ApiResponse<object>>(
                        "users",
                        request);

                if (result.Success)
                {
                    MessageBox.Show(
                        result.Message);

                    await LoadUsers();

                }
                else
                {
                    MessageBox.Show(
                        result.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnSave.IsEnabled = true;
            }
        }
    }
}
