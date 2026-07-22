using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Store_Online.Shared.UI.Controls;

public class ReanButton : Button
{
    static ReanButton()
    {
        DefaultStyleKeyProperty.OverrideMetadata(
            typeof(ReanButton),
            new FrameworkPropertyMetadata(typeof(ReanButton)));
    }

    public ReanButton()
    {
        Focusable = true;
    }

    protected override void OnClick()
    {
        if (IsBusy)
            return;

        base.OnClick();
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
            typeof(ReanButton),
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
            typeof(ReanButton),
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
            typeof(ReanButton),
            new PropertyMetadata(new CornerRadius(10)));

    #endregion

    #region IsBusy

    public bool IsBusy
    {
        get => (bool)GetValue(IsBusyProperty);
        set => SetValue(IsBusyProperty, value);
    }

    public static readonly DependencyProperty IsBusyProperty =
        DependencyProperty.Register(
            nameof(IsBusy),
            typeof(bool),
            typeof(ReanButton),
            new PropertyMetadata(false));

    #endregion

    #region BusyText

    public string BusyText
    {
        get => (string)GetValue(BusyTextProperty);
        set => SetValue(BusyTextProperty, value);
    }

    public static readonly DependencyProperty BusyTextProperty =
        DependencyProperty.Register(
            nameof(BusyText),
            typeof(string),
            typeof(ReanButton),
            new PropertyMetadata("Loading..."));

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
            typeof(ReanButton),
            new FrameworkPropertyMetadata(
                16.0,
                FrameworkPropertyMetadataOptions.AffectsRender),
            ValidateIconSize);

    private static bool ValidateIconSize(object value)
    {
        return (double)value >= 0;
    }

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
            typeof(ReanButton),
            new PropertyMetadata(Brushes.White));

    #endregion

    #region ButtonType

    public ReanButtonType ButtonType
    {
        get => (ReanButtonType)GetValue(ButtonTypeProperty);
        set => SetValue(ButtonTypeProperty, value);
    }

    public static readonly DependencyProperty ButtonTypeProperty =
        DependencyProperty.Register(
            nameof(ButtonType),
            typeof(ReanButtonType),
            typeof(ReanButton),
            new PropertyMetadata(ReanButtonType.Primary));

    #endregion
}

public enum ReanButtonType
{
    Primary,
    Secondary,
    Success,
    Warning,
    Danger,
    Outline
}
