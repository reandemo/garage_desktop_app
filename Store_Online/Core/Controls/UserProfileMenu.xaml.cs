using Store_Online.Models;
using System.Windows;
using System.Windows.Controls;

namespace Store_Online.Core.Controls
{
    public partial class UserProfileMenu : UserControl
    {
        public UserProfileMenu()
        {
            InitializeComponent();
            RefreshUser();
        }

        #region Dependency Properties

        public string UserName
        {
            get => (string)GetValue(UserNameProperty);
            set => SetValue(UserNameProperty, value);
        }

        public static readonly DependencyProperty UserNameProperty =
            DependencyProperty.Register(
                nameof(UserName),
                typeof(string),
                typeof(UserProfileMenu),
                new PropertyMetadata(string.Empty));

        public string UserRole
        {
            get => (string)GetValue(UserRoleProperty);
            set => SetValue(UserRoleProperty, value);
        }

        public static readonly DependencyProperty UserRoleProperty =
            DependencyProperty.Register(
                nameof(UserRole),
                typeof(string),
                typeof(UserProfileMenu),
                new PropertyMetadata(string.Empty));

        public string UserEmail
        {
            get => (string)GetValue(UserEmailProperty);
            set => SetValue(UserEmailProperty, value);
        }

        public static readonly DependencyProperty UserEmailProperty =
            DependencyProperty.Register(
                nameof(UserEmail),
                typeof(string),
                typeof(UserProfileMenu),
                new PropertyMetadata(string.Empty));

        public string BranchName
        {
            get => (string)GetValue(BranchNameProperty);
            set => SetValue(BranchNameProperty, value);
        }

        public static readonly DependencyProperty BranchNameProperty =
            DependencyProperty.Register(
                nameof(BranchName),
                typeof(string),
                typeof(UserProfileMenu),
                new PropertyMetadata(string.Empty));

        public string AvatarImage
        {
            get => (string)GetValue(AvatarImageProperty);
            set => SetValue(AvatarImageProperty, value);
        }

        public static readonly DependencyProperty AvatarImageProperty =
            DependencyProperty.Register(
                nameof(AvatarImage),
                typeof(string),
                typeof(UserProfileMenu),
                new PropertyMetadata(string.Empty));

        #endregion

        public event EventHandler? LogoutRequested;

        public void RefreshUser()
        {
            UserName = !string.IsNullOrWhiteSpace(AppSession.FullName)
                ? AppSession.FullName
                : !string.IsNullOrWhiteSpace(AppSession.Email)
                    ? AppSession.Email
                    : "Guest";

            UserRole = !string.IsNullOrWhiteSpace(AppSession.RoleName)
                ? AppSession.RoleName
                : "User";

            UserEmail = AppSession.Email ?? string.Empty;

            BranchName = !string.IsNullOrWhiteSpace(AppSession.BranchName)
                ? AppSession.BranchName
                : "No Branch";

            AvatarImage = AppSession.Avatar ?? string.Empty;
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            AppSession.Clear();

            RefreshUser();

            LogoutRequested?.Invoke(this, EventArgs.Empty);
        }
    }


}
