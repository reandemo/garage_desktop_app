using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Store_Online.Core.Controls
{
    /// <summary>
    /// Interaction logic for EmptyState.xaml
    /// </summary>
    public partial class EmptyState : UserControl
    {
        public EmptyState()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty IsEmptyProperty =
            DependencyProperty.Register(
                nameof(IsEmpty),
                typeof(bool),
                typeof(EmptyState),
                new PropertyMetadata(true));

        public bool IsEmpty
        {
            get => (bool)GetValue(IsEmptyProperty);
            set => SetValue(IsEmptyProperty, value);
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(
                nameof(Title),
                typeof(string),
                typeof(EmptyState),
                new PropertyMetadata("No Data"));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register(
                nameof(Description),
                typeof(string),
                typeof(EmptyState),
                new PropertyMetadata("There are no records to display."));

        public string Description
        {
            get => (string)GetValue(DescriptionProperty);
            set => SetValue(DescriptionProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(
                nameof(Icon),
                typeof(PackIconKind),
                typeof(EmptyState),
                new PropertyMetadata(PackIconKind.DatabaseOff));

        public PackIconKind Icon
        {
            get => (PackIconKind)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty ButtonTextProperty =
            DependencyProperty.Register(
                nameof(ButtonText),
                typeof(string),
                typeof(EmptyState),
                new PropertyMetadata("Add"));

        public string ButtonText
        {
            get => (string)GetValue(ButtonTextProperty);
            set => SetValue(ButtonTextProperty, value);
        }

        public static readonly DependencyProperty ButtonIconProperty =
            DependencyProperty.Register(
                nameof(ButtonIcon),
                typeof(PackIconKind),
                typeof(EmptyState),
                new PropertyMetadata(PackIconKind.Plus));

        public PackIconKind ButtonIcon
        {
            get => (PackIconKind)GetValue(ButtonIconProperty);
            set => SetValue(ButtonIconProperty, value);
        }

        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register(
                nameof(Command),
                typeof(ICommand),
                typeof(EmptyState),
                new PropertyMetadata(null));

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }
    }
}
