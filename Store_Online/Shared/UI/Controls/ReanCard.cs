using System.Drawing;
using System.Windows;
using System.Windows.Controls;

namespace Store_Online.Shared.UI.Controls;

public class ReanCard : ContentControl
{
    static ReanCard()
    {
        DefaultStyleKeyProperty.OverrideMetadata(
            typeof(ReanCard),
            new FrameworkPropertyMetadata(typeof(ReanCard)));
    }

    #region Header

    public string Header
    {
        get => (string)GetValue(HeaderProperty);
        set => SetValue(HeaderProperty, value);
    }

    public static readonly DependencyProperty HeaderProperty =
        DependencyProperty.Register(
            nameof(Header),
            typeof(string),
            typeof(ReanCard),
            new PropertyMetadata(string.Empty));

    #endregion

    #region SubHeader

    public string SubHeader
    {
        get => (string)GetValue(SubHeaderProperty);
        set => SetValue(SubHeaderProperty, value);
    }

    public static readonly DependencyProperty SubHeaderProperty =
        DependencyProperty.Register(
            nameof(SubHeader),
            typeof(string),
            typeof(ReanCard),
            new PropertyMetadata(string.Empty));

    #endregion

    #region Icon

    public string Icon
    {
        get => (string)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public static readonly DependencyProperty IconProperty =
        DependencyProperty.Register(
            nameof(Icon),
            typeof(string),
            typeof(ReanCard),
            new PropertyMetadata(string.Empty));

    #endregion

    #region CornerRadius

    public CornerRadius CornerRadius
    {
        get => (CornerRadius)GetValue(CornerRadiusProperty);
        set => SetValue(CornerRadiusProperty, value);
    }

    public static readonly DependencyProperty CornerRadiusProperty =
        DependencyProperty.Register(
            nameof(CornerRadius),
            typeof(CornerRadius),
            typeof(ReanCard),
            new PropertyMetadata(new CornerRadius(15)));

    #endregion

    #region CardBackground

    public Brush CardBackground
    {
        get => (Brush)GetValue(CardBackgroundProperty);
        set => SetValue(CardBackgroundProperty, value);
    }

    public static readonly DependencyProperty CardBackgroundProperty =
        DependencyProperty.Register(
            nameof(CardBackground),
            typeof(Brush),
            typeof(ReanCard),
            new PropertyMetadata(Brushes.White));

    #endregion

    #region BorderBrush

    public Brush CardBorderBrush
    {
        get => (Brush)GetValue(CardBorderBrushProperty);
        set => SetValue(CardBorderBrushProperty, value);
    }

    public static readonly DependencyProperty CardBorderBrushProperty =
        DependencyProperty.Register(
            nameof(CardBorderBrush),
            typeof(Brush),
            typeof(ReanCard),
            new PropertyMetadata(Brushes.LightGray));

    #endregion

    #region BorderThickness

    public Thickness CardBorderThickness
    {
        get => (Thickness)GetValue(CardBorderThicknessProperty);
        set => SetValue(CardBorderThicknessProperty, value);
    }

    public static readonly DependencyProperty CardBorderThicknessProperty =
        DependencyProperty.Register(
            nameof(CardBorderThickness),
            typeof(Thickness),
            typeof(ReanCard),
            new PropertyMetadata(new Thickness(1)));

    #endregion

    #region Padding

    public Thickness CardPadding
    {
        get => (Thickness)GetValue(CardPaddingProperty);
        set => SetValue(CardPaddingProperty, value);
    }

    public static readonly DependencyProperty CardPaddingProperty =
        DependencyProperty.Register(
            nameof(CardPadding),
            typeof(Thickness),
            typeof(ReanCard),
            new PropertyMetadata(new Thickness(20)));

    #endregion

    #region Elevation

    public double Elevation
    {
        get => (double)GetValue(ElevationProperty);
        set => SetValue(ElevationProperty, value);
    }

    public static readonly DependencyProperty ElevationProperty =
        DependencyProperty.Register(
            nameof(Elevation),
            typeof(double),
            typeof(ReanCard),
            new PropertyMetadata(10.0));

    #endregion
}

