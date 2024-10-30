# MVVM - Model & ViewModel cohesion

## Classic aggregation

As [Microsoft guidelines](https://docs.microsoft.com/en-us/archive/msdn-magazine/2009/february/patterns-wpf-apps-with-the-model-view-viewmodel-design-pattern)<sup>🔗</sup> suggest ViewModels will usually straightforwardly aggregate Models:

<details>
<summary><ins>&nbsp;Example: Book with Editor VM - sketch&nbsp;</ins></summary>
&nbsp;

```csharp
  namespace Models;
  class Book
  {
      uint required Isbn { get; init; }
      string Title { get; set; }
      // ........................................
  }
```
```csharp
  namespace ViewModels;
  class BookEditor : ViewModelBase
  {
     private Models.Book _model = // ... anyhow supplied or injected
     
     string Isbn => string.Format(ISBN_GROUP, _model.Isbn), // fictitious format provider;
  
     string Title {
        get => _model.Title;
        set { _model.Title = value; OnPropertyChanged(); }
     }
    // ........................................
  }
  ```
</details>

This practice isn't foul but leaves an itchy call of "Don't repeat yourself". 
Furthermore, there can be more ViewModels: *BookViewer* for display, *BookAbstract* for listing, and *NewBook* for creation, - all multiplying the mere propagation of the same properties.

## Inheritance variant

<table>
 <tr valign="top">
    <td>
      Let's regard the model as a parent class, <br/>from which ViewModels can be derived:
    </td>
   <td>
     <picture><img alt="VModel cohesion diagram" src="../../../_rsc/img/MVP_vm-model-cohesion.jpg"></picture>
   </td>
</tr>
</table>

### Downcasting workaround

An issue of the inheritance is that C# prevents pure downcasting, but there are workarounds possible:\
|- [Downcast unblock](../../../techniques/README+/cs-unblock_downcast.md)

### What about base ViewModel

In the classic realization, ViewModel will reasonably extend the commonly named `ViewModelBase` with everyday functionality, like notifications. 
C# doesn't support multi-inheritance, so a base is much more suitable for aggregation (injection) thus freeing the place for the model as root. 

### Contraindications

The idea assumes that model classes are open for development or alteration. The keyword `sealed` is a stop sign for the approach

### Related topics

Inheriting miscellaneous ViewModels from the root Model for different needs may use _Jagged interfaces_.\
... TO BE CONTINUED ...

## Alternatives

+ 3d party frameworks and libraries provide their own _prêt-à-porter_ MVVM suites. 
+ You may select another, more suitable and advanced option or your own design pattern.

🔚
