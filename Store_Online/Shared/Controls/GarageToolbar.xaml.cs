using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Store_Online.Shared.Controls
{
    public partial class GarageToolbar : UserControl
    {
        public GarageToolbar()
        {
            InitializeComponent();
        }

        #region SearchText

        public static readonly DependencyProperty SearchTextProperty =
            DependencyProperty.Register(
                nameof(SearchText),
                typeof(string),
                typeof(GarageToolbar),
                new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public string SearchText
        {
            get => (string)GetValue(SearchTextProperty);
            set => SetValue(SearchTextProperty, value);
        }

        #endregion

        #region NewCommand

        public static readonly DependencyProperty NewCommandProperty =
            DependencyProperty.Register(
                nameof(NewCommand),
                typeof(ICommand),
                typeof(GarageToolbar));

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
                typeof(GarageToolbar));

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
                typeof(GarageToolbar));

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
                typeof(GarageToolbar));

        public ICommand RefreshCommand
        {
            get => (ICommand)GetValue(RefreshCommandProperty);
            set => SetValue(RefreshCommandProperty, value);
        }

        #endregion

        #region ExportCommand

        public static readonly DependencyProperty ExportCommandProperty =
            DependencyProperty.Register(
                nameof(ExportCommand),
                typeof(ICommand),
                typeof(GarageToolbar));

        public ICommand ExportCommand
        {
            get => (ICommand)GetValue(ExportCommandProperty);
            set => SetValue(ExportCommandProperty, value);
        }

        #endregion
    }
}