# MVVM&nbsp;&nbsp;&mdash;&nbsp;&nbsp;Orchestration of notifications

A little reminder. WPF built-in [DataContext](https://learn.microsoft.com/dotnet/desktop/wpf/data/how-to-specify-the-binding-source)<sup>🪟</sup> has only to raise `PropertyChanged`<sup>:raising_hand:</sup> with the name of the item, which value bound elements must re-evaluate.\
&nbsp;&nbsp;&nbsp;&nbsp;<sup>:raising_hand:</sup>&nbsp;<sub>'Changed' deceives, since it's the most suitable cause but not the essence of the event.</sub>

WPF developers must know the easy [Microsoft recipe](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/data/how-to-implement-property-change-notification)<sup>🪟</sup>: `set {field = value; OnPropertyChanged();}`. It's enough for flat unsophisticated forms but mundane tasks meet ...

* tied and calculated values,
* groups and hierarchies of cross-dependent ViewModels, 
* axiomatic reuse of notification logic,
* diverse notifications mechanism (not only _PropertyChanged_)

<details><summary><ins>&nbsp;<b>And then if a ViewModel were printed on a board it would look:</b>&nbsp;</ins></summary></summary>
&nbsp;
<picture><img alt="&nbsp;Spaghetti wires snapshot" src="../../../_rsc/img/bigmessowires.com_wired-circuit.jpg" /></picture><br />
(*Found on bigmessowires.com*)

\________________________________________________________________________________________ </details>

## Idea 

<details><summary><ins>&nbsp;<b>Another snapshot from the same site may give the cue:</b>&nbsp;</ins></summary></summary>
&nbsp;
<picture><img alt="&nbsp;Perfectly organized elements on printed board" src="../../../_rsc/img/bigmessowires.com_inegrated-circuit.jpg" /></picture><br />
(*Found on bigmessowires.com*)
    
\________________________________________________________________________________________ </details>

"Chips" (logical units) shall encapsulate notification logarithms, providing calls to them. How they will be coded: aggregation, injection, or inheritance is a matter of taste and technique. As a variant, they may implement:

```csharp
interface IOrchestrating
{
    void Notify([CallerMemberName] string caller = "<n/a>");
    void MassNotify();
    Predicate<string> NameFilter { get; set; }
}
```

Besides the order, such an approach will add up the next possibilities:

+ optimization (e.g. blackout notifications for hidden UI parts or for test of layout),
+ straight "hot swap" of notification schemes (either preprogrammed on in runtime),
+ hooks for tracing, logging, whatever.

## Commands and messages

* Organization of [WPF commands](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/advanced/commanding-overview)<sup>🪟</sup> may follow the same idea, but they are easier and it's enough to pack commands in corresponding sub-ViewModels, while `CanExecute` properties may be orchestrated.
* Usual MVVM messaging, either custom or out-of-the-box, is based on properties.

## More for notification but irrelevant to the idea

There are other ways to improve notification and its realization but they aren't orchestration:

+ Everithing that [ReactiveX](https://reactivex.io/)<sup>🔗</sup> can do.
+ Any wiring on the View.
+ [Model & ViewModel cohesion](mvvm-vmodel_cohesion.md)

\___________\
🔚 🌙 2023..2025 .. image credit: bigmessowires.com
