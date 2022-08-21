# Undo/Redo stack Q&A
+ **Is stack homogenous?**

Yeaps, but generic.
+ Where's `Clear()`? 

Use `new()`.
+ **Is stack's limit mandatory?**

Nope. When not specified/applied, no check is done. It's reasonable when the number of actions is predictable.
+ **How to raise events like PropertyChanged for value itself, CanUndo i.a.? Or get hooks, like <code>OnChanged</code>.**
- [x] Override setters and realization methods

+ **Why not to overload `=` and get rid of `.Value`**

1) Setting would be ambigous (is it new value within stack or new object initialization?). Casting would deprive `=` of brevity. Direct initialization will hide the type (is **1** `short`, `uint` or `long`?).
2) operators `implicit`\\`explicit` are static - what about access to instance props and methods?

# Third parties, copyrights and licences
- Most pictograms and images are bounty of [Visual Studio Image Library](https://www.microsoft.com/en-us/download/details.aspx?id=35825). Please refer to its EULA.

- Some pieces of code are courtesy of edu and Q&A sites (stackoverflow, codeproject and others).

- The app take advantage of renowned 3d party libraries and frameworks, like [fluent assertions](https://fluentassertions.com/).
