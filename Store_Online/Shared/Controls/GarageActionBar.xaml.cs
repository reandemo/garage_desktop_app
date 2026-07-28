using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Store_Online.Shared.Controls
{
    public partial class GarageActionBar : UserControl
    {
        public GarageActionBar()
        {
            InitializeComponent();
        }

        #region NewCommand

        public static readonly DependencyProperty NewCommandProperty =
            DependencyProperty.Register(
                nameof(NewCommand),
                typeof(ICommand),
                typeof(GarageActionBar));

        public ICommand NewCommand
        {
            get => (ICommand)GetValue(NewCommandProperty);
            set => SetValue(NewCommandProperty, value);
        }

        #endregion

        #region EditCommand

        public static readonly DependencyProperty EditCommandProperty =
            DependencyProperty.Register(
                nameof(EditCommand),
                typeof(ICommand),
                typeof(GarageActionBar));

        public ICommand EditCommand
        {
            get => (ICommand)GetValue(EditCommandProperty);
            set => SetValue(EditCommandProperty, value);
        }

        #endregion

        #region DeleteCommand

        public static readonly DependencyProperty DeleteCommandProperty =
            DependencyProperty.Register(
                nameof(DeleteCommand),
                typeof(ICommand),
                typeof(GarageActionBar));

        public ICommand DeleteCommand
        {
            get => (ICommand)GetValue(DeleteCommandProperty);
            set => SetValue(DeleteCommandProperty, value);
        }

        #endregion

        #region RefreshCommand

        public static readonly DependencyProperty RefreshCommandProperty =
            DependencyProperty.Register(
                nameof(RefreshCommand),
                typeof(ICommand),
                typeof(GarageActionBar));

        public ICommand RefreshCommand
        {
            get => (ICommand)GetValue(RefreshCommandProperty);
            set => SetValue(RefreshCommandProperty, value);
        }

        #endregion

        #region SaveCommand

        public static readonly DependencyProperty SaveCommandProperty =
            DependencyProperty.Register(
                nameof(SaveCommand),
                typeof(ICommand),
                typeof(GarageActionBar));

        public ICommand SaveCommand
        {
            get => (ICommand)GetValue(SaveCommandProperty);
            set => SetValue(SaveCommandProperty, value);
        }

        #endregion

        #region ExportCommand

        public static readonly DependencyProperty ExportCommandProperty =
            DependencyProperty.Register(
                nameof(ExportCommand),
                typeof(ICommand),
                typeof(GarageActionBar));

        public ICommand ExportCommand
        {
            get => (ICommand)GetValue(ExportCommandProperty);
            set => SetValue(ExportCommandProperty, value);
        }

        #endregion
    }
}