using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Store_Online.Shared.Controls
{
    public partial class GarageFilterPanel : UserControl
    {
        public GarageFilterPanel()
        {
            InitializeComponent();
        }

        #region SearchText

        public static readonly DependencyProperty SearchTextProperty =
            DependencyProperty.Register(
                nameof(SearchText),
                typeof(string),
                typeof(GarageFilterPanel),
                new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public string SearchText
        {
            get => (string)GetValue(SearchTextProperty);
            set => SetValue(SearchTextProperty, value);
        }

        #endregion

        #region CategoryItems

        public static readonly DependencyProperty CategoryItemsProperty =
            DependencyProperty.Register(
                nameof(CategoryItems),
                typeof(IEnumerable),
                typeof(GarageFilterPanel));

        public IEnumerable CategoryItems
        {
            get => (IEnumerable)GetValue(CategoryItemsProperty);
            set => SetValue(CategoryItemsProperty, value);
        }

        #endregion

        #region SelectedCategory

        public static readonly DependencyProperty SelectedCategoryProperty =
            DependencyProperty.Register(
                nameof(SelectedCategory),
                typeof(object),
                typeof(GarageFilterPanel),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public object SelectedCategory
        {
            get => GetValue(SelectedCategoryProperty);
            set => SetValue(SelectedCategoryProperty, value);
        }

        #endregion

        #region StatusItems

        public static readonly DependencyProperty StatusItemsProperty =
            DependencyProperty.Register(
                nameof(StatusItems),
                typeof(IEnumerable),
                typeof(GarageFilterPanel));

        public IEnumerable StatusItems
        {
            get => (IEnumerable)GetValue(StatusItemsProperty);
            set => SetValue(StatusItemsProperty, value);
        }

        #endregion

        #region SelectedStatus

        public static readonly DependencyProperty SelectedStatusProperty =
            DependencyProperty.Register(
                nameof(SelectedStatus),
                typeof(object),
                typeof(GarageFilterPanel),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public object SelectedStatus
        {
            get => GetValue(SelectedStatusProperty);
            set => SetValue(SelectedStatusProperty, value);
        }

        #endregion

        #region SelectedDate

        public static readonly DependencyProperty SelectedDateProperty =
            DependencyProperty.Register(
                nameof(SelectedDate),
                typeof(DateTime?),
                typeof(GarageFilterPanel),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public DateTime? SelectedDate
        {
            get => (DateTime?)GetValue(SelectedDateProperty);
            set => SetValue(SelectedDateProperty, value);
        }

        #endregion

        #region ApplyCommand

        public static readonly DependencyProperty ApplyCommandProperty =
            DependencyProperty.Register(
                nameof(ApplyCommand),
                typeof(ICommand),
                typeof(GarageFilterPanel));

        public ICommand ApplyCommand
        {
            get => (ICommand)GetValue(ApplyCommandProperty);
            set => SetValue(ApplyCommandProperty, value);
        }

        #endregion

        #region ResetCommand

        public static readonly DependencyProperty ResetCommandProperty =
            DependencyProperty.Register(
                nameof(ResetCommand),
                typeof(ICommand),
                typeof(GarageFilterPanel));

        public ICommand ResetCommand
        {
            get => (ICommand)GetValue(ResetCommandProperty);
            set => SetValue(ResetCommandProperty, value);
        }

        #endregion
    }
}