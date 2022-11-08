# Undo/Redo stack Q&A

+ **Is stack homogenous?**\
Yeaps, but generic.

+ **What for could i need Undo only without Redo?**\
The nature of application may not suppose ability to redo. Consider a seat reservation in highly competitive scenarios, dependency on other decisions or must-be-unique random actions.

+ **Why there's RedoAll() but no UndoAll()?**\
`RedoAll()` will unconditionally restore the most recent state, while limited size stack only the oldest stored (which can be original or not).

+ **Where's `Clear()`?**\
Use `new()`.

+ **Is stack's limit mandatory?**\
Nope. When not specified/applied, no check is done. It's reasonable when the number of actions is predictable.

+ **How to raise events like PropertyChanged for value itself, CanUndo i.a.? Or get hooks, like <code>OnChanged</code>.**
- [x] Override setters and realization methods

+ **Why not to overload `=` and get rid of `.Value`**

1) Setting would be ambigous (is it new value within stack or new object initialization?). Casting would deprive `=` of brevity. Direct initialization will hide the type (is **1** `short`, `uint` or `long`?).
2) operators `implicit`\\`explicit` are static - what about access to instance props and methods?


