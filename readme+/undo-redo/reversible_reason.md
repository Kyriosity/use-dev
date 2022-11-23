# Reversible - Rationale

Hypothetical Undo/Redo _reversible_ is a tree of LIFO queues, while practical sight is the traverse through its recent branch.\
The solution for the latter is unsophisticated choice of ordered [collection](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections) (or array). That said, let's justify our construction over that... 

__Functionality__, stretching beyond `Undo`/`Redo`

+ builders of reversible objects
+ timestamps and undo/redo by them
+ action-notion vs. scripting
+ logs issue

__Syntax__, which supports that functionality in the best words, we could find

__Logics__, as guards, notifications, hooks

__Scalability__ of _functionality_ (along with _syntax_) and _logics_

 __Platform__ for next-level development of

+ wizards, recorders of macros
+ backup
+ tree explorers, branching redo<sup>:cactus:</sup>
+ testers of serial inverse functions and actions
+ syntax extensions (e.g. lambdas  `Undo(x => x..., out int steps)`)

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<sup>:cactus:</sup><sub>The idea that new action doesn't erase for good accumulated redo sequence</sub>

__Last but not least__, _Reversible_ won't perplex you with non-trivial [questions](reversible_posers.md), which its construction must have answered.
