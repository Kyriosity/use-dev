# WPF - Boolean-to-Visibility converter - Making it better

Imagine :high_brightness:Lights:high_brightness: elements on the *View* that are switched by `bool Voltage` in its *ViewModel*. That's appealing to couple them with the .NET native [BooleanToVisibilityConverter](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.booleantovisibilityconverter)<sup>🔗</sup>.

Now suppose, :flashlight:Emergency lights:flashlight: will be switched on when the _Voltage_ is off. To spare either a `VoltageOff` property with logic, or a counterpart `InvertedBooleanToVisibilityConverter`, or elaborated [triggers](https://docs.microsoft.com/en-us/dotnet/api/system.windows.style.triggers)<sup>🔗</sup> let's sketch:

<details>
<summary><ins>&nbsp;Invertible BooleanToVisibility converter&nbsp;</ins></summary>
&nbsp;

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
XAML:

 ```xaml
<local:BooleanToVisibilityConverter x:Key="BooleanToVisibility" />
<local:BooleanToVisibilityConverter x:Key="InvertedBooleanToVisibility" Invert="True" />
```
\__________________________________________
</details>

The above draft is fairly acceptable, but let's hone once and for good a decent solution:

+ supporting any constant of [Visibility](https://docs.microsoft.com/en-us/dotnet/api/system.windows.visibility)<sup>🔗</sup>
+ handling *null* for bool
+ smarter named&nbsp;<sup>:raising_hand:</sup>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<sup>:raising_hand:</sup><sub>Original naming is longish and ambiguous. [Viz](https://en.wikipedia.org/wiki/Viz.)<sup>🔗</sup> will be at least shorter than [Visibility](https://www.merriam-webster.com/dictionary/visibility)<sup>🔗</sup> (which must have been *Display*); *Vs* (versus) implies two-way, while *To* - one-way conversion.</sub>

<details>
<summary><ins>&nbsp;How these benefits will look in XAML&nbsp;</ins></summary>
&nbsp;

 ```xaml
<local:BoolVsVizConverter x:Key="BoolToViz/>
<local:BoolVsVizConverter x:Key="InvertedBoolToViz" True="Hidden" False="Visible"/>
<local:BoolVsVizConverter x:Key="BoolToVizCollapsed" False="Collapsed"/>
<local:BoolVsVizConverter x:Key="InvertedBoolToVizCollapsed" True="Collapsed" False="Visible"/>
                                                                      
<local:BoolVsVizConverter x:Key="BoolVsViz" DefaultBack="False"/>

```
\__________________________________________
</details>

---

| - **Source code** (C#):\
|--- [BoolVsVizConverter.cs](../../../,./../src/TuttiFrutti/WinClay/Converters/BoolVsVizConverter.cs) 
