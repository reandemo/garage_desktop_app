using System.Windows;
using System.Windows.Controls;

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
        if (!IsEnabled || IsBusy)
            return;

        base.OnClick();
    }

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

    #region IconPlacement

    public IconPlacement IconPlacement
    {
        get => (IconPlacement)GetValue(IconPlacementProperty);
        set => SetValue(IconPlacementProperty, value);
    }

    public static readonly DependencyProperty IconPlacementProperty =
        DependencyProperty.Register(
            nameof(IconPlacement),
            typeof(IconPlacement),
            typeof(ReanButton),
            new PropertyMetadata(IconPlacement.Left));

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
    Info,
    Light,
    Dark,
    Outline,
    Link
}

public enum IconPlacement
{
    Left,
    Right,
    Top,
    Bottom
}
