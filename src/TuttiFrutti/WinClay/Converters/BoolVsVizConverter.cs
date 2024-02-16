using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WinClay.Converters;

[ValueConversion(typeof(Visibility), typeof(bool))]
public class BoolVsVizConverter : IValueConverter
{
    public Visibility True { get; set; } = Visibility.Visible;
    public Visibility False { get; set; } = Visibility.Hidden;
    public bool? DefaultBack { get; set; }

    public virtual object? Convert(object value, Type _, object __, CultureInfo ___) {
        if (value is null)
            return null;

        if (value is not bool visible)
            return DependencyProperty.UnsetValue;

        return visible ? True : False;
    }

    public virtual object ConvertBack(object value, Type _, object __, CultureInfo ___) {
        if (value is not Visibility viz)
            return DependencyProperty.UnsetValue;

        if (TryMatch(viz, out var visible))
            return visible;

        return DefaultBack ?? DependencyProperty.UnsetValue;
    }

    private bool TryMatch(Visibility? viz, out bool res) {
        res = false;

        if (viz == True)
            res = true;
        else if (viz != False)
            return false;

        return true;
    }
}
