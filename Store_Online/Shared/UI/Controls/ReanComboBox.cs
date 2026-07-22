using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Store_Online.Shared.UI.Controls;

public class ReanComboBox : ComboBox
{
    static ReanComboBox()
    {
        DefaultStyleKeyProperty.OverrideMetadata(
            typeof(ReanComboBox),
            new FrameworkPropertyMetadata(typeof(ReanComboBox)));
    }

    #region Label

    public string Label
    {
        get => (string)GetValue(LabelProperty);
        set => SetValue(LabelProperty, value);
    }

    public static readonly DependencyProperty LabelProperty =
        DependencyProperty.Register(
            nameof(Label),
            typeof(string),
            typeof(ReanComboBox),
            new PropertyMetadata(string.Empty));

    #endregion

    #region Placeholder

    public string Placeholder
    {
        get => (string)GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }

    public static readonly DependencyProperty PlaceholderProperty =
        DependencyProperty.Register(
            nameof(Placeholder),
            typeof(string),
            typeof(ReanComboBox),
            new PropertyMetadata("Select Item"));

    #endregion

    #region LeftIcon

    public string LeftIcon
    {
        get => (string)GetValue(LeftIconProperty);
        set => SetValue(LeftIconProperty, value);
    }

    public static readonly DependencyProperty LeftIconProperty =
        DependencyProperty.Register(
            nameof(LeftIcon),
            typeof(string),
            typeof(ReanComboBox),
            new PropertyMetadata(string.Empty));

    #endregion

    #region RightIcon

    public string RightIcon
    {
        get => (string)GetValue(RightIconProperty);
        set => SetValue(RightIconProperty, value);
    }

    public static readonly DependencyProperty RightIconProperty =
        DependencyProperty.Register(
            nameof(RightIcon),
            typeof(string),
            typeof(ReanComboBox),
            new PropertyMetadata("&#xE70D;"));

    #endregion

    #region IsRequired

    public bool IsRequired
    {
        get => (bool)GetValue(IsRequiredProperty);
        set => SetValue(IsRequiredProperty, value);
    }

    public static readonly DependencyProperty IsRequiredProperty =
        DependencyProperty.Register(
            nameof(IsRequired),
            typeof(bool),
            typeof(ReanComboBox),
            new PropertyMetadata(false));

    #endregion

    #region HasError

    public bool HasError
    {
        get => (bool)GetValue(HasErrorProperty);
        set => SetValue(HasErrorProperty, value);
    }

    public static readonly DependencyProperty HasErrorProperty =
        DependencyProperty.Register(
            nameof(HasError),
            typeof(bool),
            typeof(ReanComboBox),
            new PropertyMetadata(false));

    #endregion

    #region ErrorText

    public string ErrorText
    {
        get => (string)GetValue(ErrorTextProperty);
        set => SetValue(ErrorTextProperty, value);
    }

    public static readonly DependencyProperty ErrorTextProperty =
        DependencyProperty.Register(
            nameof(ErrorText),
            typeof(string),
            typeof(ReanComboBox),
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
            typeof(ReanComboBox),
            new PropertyMetadata(new CornerRadius(10)));

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
            typeof(ReanComboBox),
            new PropertyMetadata(Brushes.Gray));

    #endregion

    #region BorderFocusBrush

    public Brush BorderFocusBrush
    {
        get => (Brush)GetValue(BorderFocusBrushProperty);
        set => SetValue(BorderFocusBrushProperty, value);
    }

    public static readonly DependencyProperty BorderFocusBrushProperty =
        DependencyProperty.Register(
            nameof(BorderFocusBrush),
            typeof(Brush),
            typeof(ReanComboBox),
            new PropertyMetadata(Brushes.DodgerBlue));

    #endregion

    #region PopupBackground

    public Brush PopupBackground
    {
        get => (Brush)GetValue(PopupBackgroundProperty);
        set => SetValue(PopupBackgroundProperty, value);
    }

    public static readonly DependencyProperty PopupBackgroundProperty =
        DependencyProperty.Register(
            nameof(PopupBackground),
            typeof(Brush),
            typeof(ReanComboBox),
            new PropertyMetadata(Brushes.White));

    #endregion

    #region PopupBorderBrush

    public Brush PopupBorderBrush
    {
        get => (Brush)GetValue(PopupBorderBrushProperty);
        set => SetValue(PopupBorderBrushProperty, value);
    }

    public static readonly DependencyProperty PopupBorderBrushProperty =
        DependencyProperty.Register(
            nameof(PopupBorderBrush),
            typeof(Brush),
            typeof(ReanComboBox),
            new PropertyMetadata(Brushes.LightGray));

    #endregion

    #region ItemHeight

    public double ItemHeight
    {
        get => (double)GetValue(ItemHeightProperty);
        set => SetValue(ItemHeightProperty, value);
    }

    public static readonly DependencyProperty ItemHeightProperty =
        DependencyProperty.Register(
            nameof(ItemHeight),
            typeof(double),
            typeof(ReanComboBox),
            new PropertyMetadata(36.0));

    #endregion

    #region MaxDropDownHeight

    public new double MaxDropDownHeight
    {
        get => (double)GetValue(MaxDropDownHeightProperty);
        set => SetValue(MaxDropDownHeightProperty, value);
    }

    public static readonly new DependencyProperty MaxDropDownHeightProperty =
        DependencyProperty.Register(
            nameof(MaxDropDownHeight),
            typeof(double),
            typeof(ReanComboBox),
            new PropertyMetadata(300.0));

    #endregion

    #region IsSearchable

    public bool IsSearchable
    {
        get => (bool)GetValue(IsSearchableProperty);
        set => SetValue(IsSearchableProperty, value);
    }

    public static readonly DependencyProperty IsSearchableProperty =
        DependencyProperty.Register(
            nameof(IsSearchable),
            typeof(bool),
            typeof(ReanComboBox),
            new PropertyMetadata(false));

    #endregion
}
