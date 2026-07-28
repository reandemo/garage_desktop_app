using System.Windows;
using System.Windows.Controls;

namespace Store_Online.Shared.Controls
{
    public partial class GarageCard : UserControl
    {
        public GarageCard()
        {
            InitializeComponent();
        }


        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(
                nameof(Title),
                typeof(string),
                typeof(GarageCard),
                new PropertyMetadata(string.Empty));


        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }


        public static readonly DependencyProperty SubtitleProperty =
            DependencyProperty.Register(
                nameof(Subtitle),
                typeof(string),
                typeof(GarageCard),
                new PropertyMetadata(string.Empty));


        public string Subtitle
        {
            get => (string)GetValue(SubtitleProperty);
            set => SetValue(SubtitleProperty, value);
        }


        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(
                nameof(Icon),
                typeof(string),
                typeof(GarageCard),
                new PropertyMetadata(string.Empty));


        public string Icon
        {
            get => (string)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }
    }
}