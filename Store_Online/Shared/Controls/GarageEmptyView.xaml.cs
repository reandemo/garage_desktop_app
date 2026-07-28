using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Store_Online.Shared.Controls
{
    public partial class GarageEmptyView : UserControl
    {
        public GarageEmptyView()
        {
            InitializeComponent();
        }

        #region Title

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(
                nameof(Title),
                typeof(string),
                typeof(GarageEmptyView),
                new PropertyMetadata("No Data"));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        #endregion

        #region Description

        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register(
                nameof(Description),
                typeof(string),
                typeof(GarageEmptyView),
                new PropertyMetadata("There is currently no information to display."));

        public string Description
        {
            get => (string)GetValue(DescriptionProperty);
            set => SetValue(DescriptionProperty, value);
        }

        #endregion

        #region ButtonText

        public static readonly DependencyProperty ButtonTextProperty =
            DependencyProperty.Register(
                nameof(ButtonText),
                typeof(string),
                typeof(GarageEmptyView),
                new PropertyMetadata("Create New"));

        public string ButtonText
        {
            get => (string)GetValue(ButtonTextProperty);
            set => SetValue(ButtonTextProperty, value);
        }

        #endregion

        #region IconKind

        public static readonly DependencyProperty IconKindProperty =
            DependencyProperty.Register(
                nameof(IconKind),
                typeof(PackIconKind),
                typeof(GarageEmptyView),
                new PropertyMetadata(PackIconKind.DatabaseOff));

        public PackIconKind IconKind
        {
            get => (PackIconKind)GetValue(IconKindProperty);
            set => SetValue(IconKindProperty, value);
        }

        #endregion

        #region ActionCommand

        public static readonly DependencyProperty ActionCommandProperty =
            DependencyProperty.Register(
                nameof(ActionCommand),
                typeof(ICommand),
                typeof(GarageEmptyView));

        public ICommand ActionCommand
        {
            get => (ICommand)GetValue(ActionCommandProperty);
            set => SetValue(ActionCommandProperty, value);
        }

        #endregion
    }
}