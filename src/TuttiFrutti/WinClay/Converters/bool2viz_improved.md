# <code>W&thinsp;P&thinsp;F</code> &nbsp;&mdash;&nbsp; improved💫 &nbsp;&mdash;&nbsp; `Boolean-to-Visibility` converter

Imagine :high_brightness:Lights:high_brightness: elements on the *View* that are switched by `bool Voltage` in its *ViewModel*. That's appealing to couple them with the .NET native [`BooleanToVisibilityConverter`](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.booleantovisibilityconverter).

Now suppose, :flashlight:Emergency lights:flashlight: will be switched on when the _Voltage_ is off. To spare either a `VoltageOff` property with logic, or a counterpart `InvertedBooleanToVisibilityConverter`, or elaborated [`Style.Triggers`](https://docs.microsoft.com/en-us/dotnet/api/system.windows.style.triggers), let's sketch:

<details>
<summary><ins>&nbsp;Invertible BooleanToVisibility converter (<i>beta-version</i>):&nbsp;</ins></summary>
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

The above draft is fairly acceptable, but let's hone it once and for good, to an accomplished version:

+ supporting any constant of [`Visibility`](https://docs.microsoft.com/en-us/dotnet/api/system.windows.visibility)
+ handling *null* for bool
+ neater named&nbsp;<sup>:raising_hand:</sup>

<div align="right"><sup>🙋</sup> <samp>Original naming is longish and ambiguous.<br />
<b><i>Viz</i></b> will be at least shorter than <a href="https://www.merriam-webster.com/dictionary/visibility">Visibility</a><sup>🔗</sup> (which must have been <i>Display</i>);
<br /><i><b>Vs</b></i> (versus) implies two-way, while <i><b>To</b></i> &thinsp;&mdash;&thinsp; one-way conversion.</samp></div>

### How these benefits will look in XAML:

 ```xaml
<local:BoolVsVizConverter x:Key="BoolToViz/>
<local:BoolVsVizConverter x:Key="InvertedBoolToViz" True="Hidden" False="Visible"/>
<local:BoolVsVizConverter x:Key="BoolToVizCollapsed" False="Collapsed"/>
<local:BoolVsVizConverter x:Key="InvertedBoolToVizCollapsed" True="Collapsed" False="Visible"/>
                                                                      
<local:BoolVsVizConverter x:Key="BoolVsViz" DefaultBack="False"/>

```

|&thinsp;- **Here is the source code** (**`C#`**):\
|&thinsp;-&thinsp;- [BoolVsVizConverter.cs](../../../,./../../src/TuttiFrutti/WinClay/Converters/BoolVsVizConverter.cs) 

\___________\
🔚 .. voilà ..
