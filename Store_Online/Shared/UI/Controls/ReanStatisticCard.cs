using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Store_Online.Shared.UI.Controls;

public class ReanStatisticCard : Control
{
    static ReanStatisticCard()
    {
        DefaultStyleKeyProperty.OverrideMetadata(
            typeof(ReanStatisticCard),
            new FrameworkPropertyMetadata(typeof(ReanStatisticCard)));
    }

    #region Title

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public static readonly DependencyProperty TitleProperty =
        DependencyProperty.Register(
            nameof(Title),
            typeof(string),
            typeof(ReanStatisticCard),
            new PropertyMetadata(string.Empty));

    #endregion

    #region Value

    public string Value
    {
        get => (string)GetValue(ValueProperty);
        set => SetValue(ValueProperty, value);
    }

    public static readonly DependencyProperty ValueProperty =
        DependencyProperty.Register(
            nameof(Value),
            typeof(string),
            typeof(ReanStatisticCard),
            new PropertyMetadata("0"));

    #endregion

    #region Description

    public string Description
    {
        get => (string)GetValue(DescriptionProperty);
        set => SetValue(DescriptionProperty, value);
    }

    public static readonly DependencyProperty DescriptionProperty =
        DependencyProperty.Register(
            nameof(Description),
            typeof(string),
            typeof(ReanStatisticCard),
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
            typeof(ReanStatisticCard),
            new PropertyMetadata(string.Empty));

    #endregion

    #region Trend

    public string Trend
    {
        get => (string)GetValue(TrendProperty);
        set => SetValue(TrendProperty, value);
    }

    public static readonly DependencyProperty TrendProperty =
        DependencyProperty.Register(
            nameof(Trend),
            typeof(string),
            typeof(ReanStatisticCard),
            new PropertyMetadata("+0%"));

    #endregion

    #region TrendBrush

    public Brush TrendBrush
    {
        get => (Brush)GetValue(TrendBrushProperty);
        set => SetValue(TrendBrushProperty, value);
    }

    public static readonly DependencyProperty TrendBrushProperty =
        DependencyProperty.Register(
            nameof(TrendBrush),
            typeof(Brush),
            typeof(ReanStatisticCard),
            new PropertyMetadata(Brushes.Green));

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
            typeof(ReanStatisticCard),
            new PropertyMetadata(Brushes.DodgerBlue));

    #endregion

    #region IconBackground

    public Brush IconBackground
    {
        get => (Brush)GetValue(IconBackgroundProperty);
        set => SetValue(IconBackgroundProperty, value);
    }

    public static readonly DependencyProperty IconBackgroundProperty =
        DependencyProperty.Register(
            nameof(IconBackground),
            typeof(Brush),
            typeof(ReanStatisticCard),
            new PropertyMetadata(Brushes.LightBlue));

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
            typeof(ReanStatisticCard),
            new PropertyMetadata(new CornerRadius(16)));

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
            typeof(ReanStatisticCard),
            new PropertyMetadata(Brushes.White));

    #endregion

    #region CardBorderBrush

    public Brush CardBorderBrush
    {
        get => (Brush)GetValue(CardBorderBrushProperty);
        set => SetValue(CardBorderBrushProperty, value);
    }

    public static readonly DependencyProperty CardBorderBrushProperty =
        DependencyProperty.Register(
            nameof(CardBorderBrush),
            typeof(Brush),
            typeof(ReanStatisticCard),
            new PropertyMetadata(Brushes.LightGray));

    #endregion

    #region CardBorderThickness

    public Thickness CardBorderThickness
    {
        get => (Thickness)GetValue(CardBorderThicknessProperty);
        set => SetValue(CardBorderThicknessProperty, value);
    }

    public static readonly DependencyProperty CardBorderThicknessProperty =
        DependencyProperty.Register(
            nameof(CardBorderThickness),
            typeof(Thickness),
            typeof(ReanStatisticCard),
            new PropertyMetadata(new Thickness(1)));

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
            typeof(ReanStatisticCard),
            new PropertyMetadata(10.0));

    #endregion

    #region IsLoading

    public bool IsLoading
    {
        get => (bool)GetValue(IsLoadingProperty);
        set => SetValue(IsLoadingProperty, value);
    }

    public static readonly DependencyProperty IsLoadingProperty =
        DependencyProperty.Register(
            nameof(IsLoading),
            typeof(bool),
            typeof(ReanStatisticCard),
            new PropertyMetadata(false));

    #endregion
}
