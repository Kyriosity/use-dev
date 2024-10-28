# C# &mdash; Downcasting unblocking

> **Reminder**: Always draw a base (parent) class in UML **up** to one derived from it, for an explicit view of up- and downcasting.

Contrary to carefree **up**casting C# will prevent assigning pure base class with any derived (downcast), even when there's no piece of extension there.

Naturally, some patterns may tempt you to overcome this limitation. E.g. for an effective way of data exchange between layers in multitier architecture, converters, and presenters, when defaults or auto-calculations will safely fit extensions (what .NET can't predict).

## _Rush_: unified interfaces

Using the same `class` of composed `interface`s is extremely simple but it will build up monoliths with big design holes, which may/will pay off later (e.g. non-deployable assemblies).

It's wise to reserve this option for prototypes only.

## _Universal_: (de)serialization

Serialization to a format like JSON and further deserialization may be a fast and obvious solution with a pair of "native" calls. The disadvantage is obvious:  performance charges.

## _Smart_: "up-down"-casting

🚧DRAFT
```csharp
var book = ViewModel.Create(...);
Model.Fill(book);

```

## _Best_: yours

Circumstances and your experiences may suggest even a better workaround.

🔚
