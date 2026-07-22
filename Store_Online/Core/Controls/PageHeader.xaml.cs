using MaterialDesignThemes.Wpf;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Store_Online.Core.Controls
{
    public partial class PageHeader : UserControl
    {
        public PageHeader()
        {
            InitializeComponent();
        }

        #region Routed Events

        public static readonly RoutedEvent ClickEvent =
            EventManager.RegisterRoutedEvent(
                nameof(Click),
                RoutingStrategy.Bubble,
                typeof(RoutedEventHandler),
                typeof(PageHeader));

        public event RoutedEventHandler Click
        {
            add => AddHandler(ClickEvent, value);
            remove => RemoveHandler(ClickEvent, value);
        }

        private void HeaderButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(ClickEvent));
        }

        #endregion

        #region Title

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(
                nameof(Title),
                typeof(string),
                typeof(PageHeader),
                new PropertyMetadata(string.Empty));

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
                typeof(PageHeader),
                new PropertyMetadata(string.Empty));

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
                typeof(PageHeader),
                new PropertyMetadata("Add"));

        public string ButtonText
        {
            get => (string)GetValue(ButtonTextProperty);
            set => SetValue(ButtonTextProperty, value);
        }

        #endregion

        #region ButtonIcon

        public static readonly DependencyProperty ButtonIconProperty =
            DependencyProperty.Register(
                nameof(ButtonIcon),
                typeof(PackIconKind),
                typeof(PageHeader),
                new PropertyMetadata(PackIconKind.Plus));

        public PackIconKind ButtonIcon
        {
            get => (PackIconKind)GetValue(ButtonIconProperty);
            set => SetValue(ButtonIconProperty, value);
        }

        #endregion

        #region ButtonBrush

        public static readonly DependencyProperty ButtonBrushProperty =
            DependencyProperty.Register(
                nameof(ButtonBrush),
                typeof(Brush),
                typeof(PageHeader),
                new PropertyMetadata(Brushes.DodgerBlue));

        public Brush ButtonBrush
        {
            get => (Brush)GetValue(ButtonBrushProperty);
            set => SetValue(ButtonBrushProperty, value);
        }

        #endregion

        #region Command

        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register(
                nameof(Command),
                typeof(ICommand),
                typeof(PageHeader),
                new PropertyMetadata(null));

        public ICommand? Command
        {
            get => (ICommand?)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        #endregion
    }
}