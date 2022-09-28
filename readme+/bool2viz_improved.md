# WPF: Improving Boolean-to-Visibility converter
Imagine :high_brightness:Lights:high_brightness: elements on the *View* that are switched by `bool Power` in *ViewModel*.\
It's appealing to couple them with the .NET native [BooleanToVisibilityConverter](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.booleantovisibilityconverter).

Now suppose, :flashlight:Emergency lights:flashlight: will be switched on when the power is off. To spare either a `PowerOff` property with logic, or inverse counterpart `InvertedBooleanToVisibilityConverter`, or elaborated [triggers](https://docs.microsoft.com/en-us/dotnet/api/system.windows.style.triggers) let's sketch:

<details>
<summary><b>Invertible BooleanToVisibility converter</b></summary>

```csharp
public class BooleanToVisibilityConverter : IValueConverter
{
    public bool Invert { get; set; }

    public object Convert(object value, Type _, object __, CultureInfo ___) => value is not bool visible ? 
        throw new ArgumentException($"{nameof(value)} must be bool") :
        Invert ^ visible ? Visibility.Visible : Visibility.Hidden;

    /// ConvertBack(...
}
``` 
... in XAML:

 ```xaml
<local:BooleanToVisibilityConverter x:Key="BooleanToVisibility" />
<local:BooleanToVisibilityConverter x:Key="InvertedBooleanToVisibility" Invert="True" />
```
</details>

The above draft is fairly acceptable, but let's hone once and for good a decent solution:
+ supporting any constant of [Visibility](https://docs.microsoft.com/en-us/dotnet/api/system.windows.visibility)
+ handling *null* for bool
+ smarter named&nbsp;<sup>:raising_hand:</sup>

&nbsp;&nbsp;&nbsp;&nbsp;<sup>:raising_hand:</sup><sub>Original naming is longish and ambiguous. [Viz](https://en.wikipedia.org/wiki/Viz.) will be at least shorter than [Visibility](https://www.merriam-webster.com/dictionary/visibility) (which must have been *Display*); *Vs* (versus) implies two-way, while *To* - one-way conversion.</sub>

Let's demonstrate the named benefits with:
<details>
<summary><b>Declaration in XAML</b></summary>

 ```xaml
<local:BoolVsVizConverter x:Key="BoolToViz/>
<local:BoolVsVizConverter x:Key="InvertedBoolToViz" True="Hidden" False="Visible"/>
<local:BoolVsVizConverter x:Key="BoolToVizCollapsed" False="Collapsed"/>
<local:BoolVsVizConverter x:Key="InvertedBoolToVizCollapsed" True="Collapsed" False="Visible"/>
                                                                      
<local:BoolVsVizConverter x:Key="BoolVsViz" DefaultBack="False"/>

```

</details>

That is backed up by this code: [BoolVsVizConverter](..//foundation/Clay/Win/Converters/BoolVsVizConverter.cs) 
