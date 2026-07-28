using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Store_Online.Shared.Controls
{
    public partial class GarageSearchBox : UserControl
    {
        public GarageSearchBox()
        {
            InitializeComponent();

            ClearCommand = new RelayCommand(_ => Clear());

            PART_TextBox.TextChanged += PART_TextBox_TextChanged;
        }

        #region Dependency Properties

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(
                nameof(Text),
                typeof(string),
                typeof(GarageSearchBox),
                new FrameworkPropertyMetadata(
                    string.Empty,
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public static readonly DependencyProperty PlaceholderProperty =
            DependencyProperty.Register(
                nameof(Placeholder),
                typeof(string),
                typeof(GarageSearchBox),
                new PropertyMetadata("Search..."));

        public string Placeholder
        {
            get => (string)GetValue(PlaceholderProperty);
            set => SetValue(PlaceholderProperty, value);
        }

        #endregion

        #region Public API

        public ICommand ClearCommand { get; }

        public void Clear()
        {
            Text = string.Empty;
        }

        public void FocusSearch()
        {
            PART_TextBox.Focus();
        }

        #endregion

        #region Events

        public event TextChangedEventHandler TextChanged;

        private void PART_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Text = PART_TextBox.Text;

            TextChanged?.Invoke(this, e);
        }

        #endregion

        #region RelayCommand

        private sealed class RelayCommand : ICommand
        {
            private readonly Action<object> _execute;

            public RelayCommand(Action<object> execute)
            {
                _execute = execute;
            }

            public bool CanExecute(object parameter) => true;

            public void Execute(object parameter)
            {
                _execute(parameter);
            }

            public event EventHandler CanExecuteChanged
            {
                add { }
                remove { }
            }
        }

        #endregion
    }
}