# MVVM - Model & ViewModel cohesion

## Classic aggregation

As [Microsoft guidelines](https://docs.microsoft.com/en-us/archive/msdn-magazine/2009/february/patterns-wpf-apps-with-the-model-view-viewmodel-design-pattern) suggest ViewModels will usually aggregate Models in a straightforward fashion:

<details>
<summary><ins>&nbsp;Book with Editor VM - sketch&nbsp;</ins></summary>
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

Nothing foul in this practice but an itchy call of "Don't repeat yourself". Furthermore, there can be more ViewModels: *BookViewer* for display, *BookAbstract* for listing, and *NewBook* for creation, - all multiplying the mere propagation of the same properties.

## Inheritance variant

|   |  |
| ------------- | ------------- |
| Let's regard model as a parent class, <br/>from which ViewModels can be derived:<br/><br/><br/><br/>| ![VModel cohesion diagram](../_rsc/images/MVP_vm-model-cohesion.jpg)  |

### Downcasting workaround

An issue of the inheritance is that C# prevents pure downcasting, but there are workarounds possible:\
|- [Downcasting impedance](cs_downcast-impedance.md)

### What about base ViewModel

In the classic realization, ViewModel will reasonably extend the commonly named `ViewModelBase` with everyday functionality, like notifications. 
C# doesn't support multi-inheritance, so a base is much more suitable for aggregation (injection) thus freeing the place for the model as root. 

### Contraindications

The idea assumes that model classes are open for development or alteration. The keyword `sealed` is a stop sign for the approach

### Related topics

Inheriting miscellaneous ViewModels from the root Model for different needs may use _Jagged interfaces_.
... TO BE CONTINUED ...

## Alternatives

+ 3d party frameworks and libraries provide their own _prêt-à-porter_ MVVM suites. 
+ You may select an alternative or your own design pattern: more suitable and advanced.
