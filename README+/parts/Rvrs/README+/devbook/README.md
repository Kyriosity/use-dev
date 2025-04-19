# Reversible on .NET &nbsp; &mdash; &nbsp; Development book

## Some groundstones

Inspired by [intro snippet](../../) let's sketch a minimum valuable functionality and grant it the best optimal syntax:

```csharp
var angle = UndoOnly.Of<byte>(0);
angle.Value = 3; angle.Value = 17; angle.Value = 90;

if (angle.Value > 80)
   angle.Undo();
   
angle.Value = 77;
  
var stepsUndo = angle.Count() - 1;
angle.Undo(stepsUndo); 
angle.Undo(); // exception: out of range
```

Then granulate interfaces out this:

```csharp
interface IUndoable { void Undo(int steps = 1); }
interface ICounted<T> { T Value {get; set; }; int Count { get; } }

```

The next step is to add Redo

```csharp
var subj = UndoRedo.Of({ "rotate 30°", "flop", "fill blue", "UNDO", "fill white", "blur", "contrast +20" });

subj.Undo(subj.Index \ 2); 

subj.RedoAll(); 
subj.Redo(); // exception

```

Then extend interfaces: 

```csharp

interface IUndoRedoable : IUndoable { void Redo(int steps = 1); void RedoAll(); }
interface IIndexed<T> : ICounted<T> { int Index { get; } }

```

## Factories and builders

## Dynamic composition

🚧 ... TO BE CONTINUED ...
