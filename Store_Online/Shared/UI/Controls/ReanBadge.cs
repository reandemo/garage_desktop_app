using System.Drawing;
using System.Windows;
using System.Windows.Controls;

namespace Store_Online.Shared.UI.Controls;

public class ReanBadge : Control
{
    static ReanBadge()
    {
        DefaultStyleKeyProperty.OverrideMetadata(
            typeof(ReanBadge),
            new FrameworkPropertyMetadata(typeof(ReanBadge)));
    }

    #region Text

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register(
            nameof(Text),
            typeof(string),
            typeof(ReanBadge),
            new PropertyMetadata(string.Empty));

    #endregion

    #region Glyph

    public string Glyph
    {
        get => (string)GetValue(GlyphProperty);
        set => SetValue(GlyphProperty, value);
    }

    public static readonly DependencyProperty GlyphProperty =
        DependencyProperty.Register(
            nameof(Glyph),
            typeof(string),
            typeof(ReanBadge),
            new PropertyMetadata(string.Empty));

    #endregion

    #region BadgeBackground

    public Brush BadgeBackground
    {
        get => (Brush)GetValue(BadgeBackgroundProperty);
        set => SetValue(BadgeBackgroundProperty, value);
    }

    public static readonly DependencyProperty BadgeBackgroundProperty =
        DependencyProperty.Register(
            nameof(BadgeBackground),
            typeof(Brush),
            typeof(ReanBadge),
            new PropertyMetadata(Brushes.DodgerBlue));

    #endregion

    #region BadgeForeground

    public Brush BadgeForeground
    {
        get => (Brush)GetValue(BadgeForegroundProperty);
        set => SetValue(BadgeForegroundProperty, value);
    }

    public static readonly DependencyProperty BadgeForegroundProperty =
        DependencyProperty.Register(
            nameof(BadgeForeground),
            typeof(Brush),
            typeof(ReanBadge),
            new PropertyMetadata(Brushes.White));

    #endregion

    #region BadgeBorderBrush

    public Brush BadgeBorderBrush
    {
        get => (Brush)GetValue(BadgeBorderBrushProperty);
        set => SetValue(BadgeBorderBrushProperty, value);
    }

    public static readonly DependencyProperty BadgeBorderBrushProperty =
        DependencyProperty.Register(
            nameof(BadgeBorderBrush),
            typeof(Brush),
            typeof(ReanBadge),
            new PropertyMetadata(Brushes.Transparent));

    #endregion

    #region BadgeBorderThickness

    public Thickness BadgeBorderThickness
    {
        get => (Thickness)GetValue(BadgeBorderThicknessProperty);
        set => SetValue(BadgeBorderThicknessProperty, value);
    }

    public static readonly DependencyProperty BadgeBorderThicknessProperty =
        DependencyProperty.Register(
            nameof(BadgeBorderThickness),
            typeof(Thickness),
            typeof(ReanBadge),
            new PropertyMetadata(new Thickness(0)));

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
            typeof(ReanBadge),
            new PropertyMetadata(new CornerRadius(12)));

    #endregion

    #region Padding

    public Thickness BadgePadding
    {
        get => (Thickness)GetValue(BadgePaddingProperty);
        set => SetValue(BadgePaddingProperty, value);
    }

    public static readonly DependencyProperty BadgePaddingProperty =
        DependencyProperty.Register(
            nameof(BadgePadding),
            typeof(Thickness),
            typeof(ReanBadge),
            new PropertyMetadata(new Thickness(10, 4, 10, 4)));

    #endregion

    #region FontSize

    public double BadgeFontSize
    {
        get => (double)GetValue(BadgeFontSizeProperty);
        set => SetValue(BadgeFontSizeProperty, value);
    }

    public static readonly DependencyProperty BadgeFontSizeProperty =
        DependencyProperty.Register(
            nameof(BadgeFontSize),
            typeof(double),
            typeof(ReanBadge),
            new PropertyMetadata(12.0));

    #endregion

    #region FontWeight

    public FontWeight BadgeFontWeight
    {
        get => (FontWeight)GetValue(BadgeFontWeightProperty);
        set => SetValue(BadgeFontWeightProperty, value);
    }

    public static readonly DependencyProperty BadgeFontWeightProperty =
        DependencyProperty.Register(
            nameof(BadgeFontWeight),
            typeof(FontWeight),
            typeof(ReanBadge),
            new PropertyMetadata(FontWeights.SemiBold));

    #endregion

    #region IconBrush

    public Brush IconBrush
    {
        get => (Brush)GetValue(IconBrushProperty);
        set => SetValue(IconBrushProperty, value);
    }

    public static readonly DependencyProperty IconBrushProperty =
        DependencyProperty.Register(
            nameof(IconBrush),
            typeof(Brush),
            typeof(ReanBadge),
            new PropertyMetadata(Brushes.White));

    #endregion

    #region IconSize

    public double IconSize
    {
        get => (double)GetValue(IconSizeProperty);
        set => SetValue(IconSizeProperty, value);
    }

    public static readonly DependencyProperty IconSizeProperty =
        DependencyProperty.Register(
            nameof(IconSize),
            typeof(double),
            typeof(ReanBadge),
            new PropertyMetadata(14.0));

    #endregion

    #region IsOutlined

    public bool IsOutlined
    {
        get => (bool)GetValue(IsOutlinedProperty);
        set => SetValue(IsOutlinedProperty, value);
    }

    public static readonly DependencyProperty IsOutlinedProperty =
        DependencyProperty.Register(
            nameof(IsOutlined),
            typeof(bool),
            typeof(ReanBadge),
            new PropertyMetadata(false));

    #endregion

    #region BadgeType

    public ReanBadgeType BadgeType
    {
        get => (ReanBadgeType)GetValue(BadgeTypeProperty);
        set => SetValue(BadgeTypeProperty, value);
    }

    public static readonly DependencyProperty BadgeTypeProperty =
        DependencyProperty.Register(
            nameof(BadgeType),
            typeof(ReanBadgeType),
            typeof(ReanBadge),
            new PropertyMetadata(ReanBadgeType.Primary));

    #endregion
}

public enum ReanBadgeType
{
    Primary,
    Success,
    Warning,
    Danger,
    Info,
    Secondary
}
