# MVVM - Model & ViewModel cohesion

## Classic aggregation

As [Microsoft guidelines](https://docs.microsoft.com/en-us/archive/msdn-magazine/2009/february/patterns-wpf-apps-with-the-model-view-viewmodel-design-pattern) suggest ViewModels will usually aggregate Models in a straightforward fashion:

<details>
  <summary><ins>&nbsp;Ordinary aggregation - sketch&nbsp;</ins></summary>
  
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
     
     string Isbn => string.Format(ISBN_GROUP, _model.Isbn), // fictitious formatter;
  
     string Title {
        get => _model.Title;
        set { _model.Title = value; OnPropertyChanged(); }
     }
    // ........................................
  }
  ```
</details>

There's nothing foul in this practice but an itchy call of "Don't repeat yourself". Furthermore, there can be more ViewModels: *BookViewer* for display, *BookAbstract* for listing, *NewBook* for creation, - all multiplying the mere propagation of pretty much properties.

## Inheritance variant

|   |  |
| ------------- | ------------- |
| Let's regard model as a parent class, <br/>from which ViewModels can be derived:<br/><br/><br/><br/>| ![VModel cohesion diagram](../_rsc/images/MVP_vm-model-cohesion.jpg)  |

### Downcasting workaround

An issue of the inheritance is that C# prevents pure downcasting, but there're workarounds possible:\
|- [Downcasting impedance](cs_downcast-impedance.md)

### What about ViewModelBase

In the classic realization, ViewModel will reasonably extend `ViewModelBase` (familiar name) with everyday functionality, like notifications. 
C# doesn't support multi-inheritance, then a base is much more suitable for aggregation (injection) thus giving the way to model as parent. 

### Contraindications

The idea assumes that model classes are open for development or alteration. The keyword `sealed` is a stop sign for the approach

... TO BE CONTINUED ...

## Alternatives

+ Seasoned framework and libraries provide their own _prêt-à-porter_ MVVM suites. 
+ You may select an alternative or your own design pattern, one more suitable and advanced.
