# MVVM - Orchestration of notifications

A little reminder. WPF built-in [DataContext](https://learn.microsoft.com/dotnet/desktop/wpf/data/how-to-specify-the-binding-source) has only to raise `PropertyChanged`<sup>:raising_hand:</sup> with the name of the item, which value bound elements must re-evaluate.\
&nbsp;&nbsp;&nbsp;&nbsp;<sup>:raising_hand:</sup>&nbsp;<sub>'Changed' deceives, since it's the most suitable cause but not the essence of the event.</sub>

WPF developers must know the easy [Microsoft recipe](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/data/how-to-implement-property-change-notification): `set {field = value; OnPropertyChanged();}`. It's enough for flat unsophisticated forms but development meets:

* tied and calculated values,
* groups and hierarchies of cross-dependent ViewModels, 
* axiomatic reuse of notification logic,
* diverse notifications mechanism (not only _PropertyChanged_)

<details>
<summary><ins>&nbsp;And then if a ViewModel were printed on a board it would look:&nbsp;</ins></summary></summary>
&nbsp;
   
![Spaghetti wires snapshot from bigmessowires.com/](../_rsc/images/bigmessowires.com_wired-circuit.jpg)\
(*Found on bigmessowires.com*)\
\________________________________________________________________________________________
</details>


## Idea 

<details>
<summary><ins>&nbsp;Another snapshot from the same site may give the cue:&nbsp;</ins></summary></summary>
&nbsp;

![Order illustration of chips from bigmessowires.com/](../_rsc/images/bigmessowires.com_inegrated-circuit.jpg)

(*Found on bigmessowires.com*)\
\________________________________________________________________________________________
</details>

"Chips" shall encapsulate notification logic with some calls. It's a matter of taste how they will be implemented: aggregation. injection or inheritance, but shall implement something like:

```csharp
interface IOrchestrating
{
    void Notify([CallerMemberName] string caller = "<n/a>");
    void MassNotify();
    Predicate<string> NameFilter { get; set; }
}
```

Besides the order, such an approach will add up the next possibilities:

+ optimization (e.g. blackout notifications for hidden UI parts),
+ easy swap of notification schemes,
+ hooks for tracing, logging, whatever.

## Commands and messages

* Organization of [WPF commands](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/advanced/commanding-overview) may follow the same idea, but they are easier and it's enough to pack commands in corresponding sub-ViewModels, while `CanExecute` properties may be orchestrated.
* Usual MVVM messaging, either custom or out-of-the-box, is based on properties.

## Beyond this topic

There are other ways to improve notification and its realization but they aren't orchestration:

+ Everithing that [ReactiveX](https://reactivex.io/) can do.
+ Any wiring on the View side.
+ [Model & ViewModel cohesion](mvvm_vmodel-cohesion.md)
