# Reversible on .NET - Intro

<p dir="rtl";><span style="font-variant:small-caps;"><b>r&nbsp;e v e r s i b l e&nbsp;&nbsp;&nbsp;</b></span><br><b>a:</b>&nbsp;capable of going through a series of actions<br/>such as changes) either backward or forward)</p>
<p dir="rtl";><i>Merriam-Webster dictionary</i></p>

&nbsp;\
Ability to __undo__ and then, likely, __redo__ actions is constituent and multifaceted for most applications. Besides traditional usage Undo-Redo may replace tedious confirmation ("are you sure"), run wizards, explore tree structures. 

Let's knock ourselves out to implement a _reversible_ provider in a project, deserving positive review and integration.

We'll begin with a little demonstration:

> :clamp: __some C# attributes are cut for emphasis__
<details>
<summary>:chess_pawn:&nbsp;<ins>&nbsp;Take a dummy class of a reputable mental project&nbsp;</ins></summary>

```csharp
class Chess<T>
{
    bool _blackOn;
    virtual T _move { get; set; }

    T Move {
        get => _move;
        set {
            Validate(value);
            _move = value; _blackOn ^= true;
            Notify();
        }
    }

    virtual void Validate(T value) { ... } // check notation and validate move here
    virtual void Notify() => Console.WriteLine($"{(_blackOn ? "black" : "white")}: {Move}");
}
```

</details>

<details>
    <summary>:previous_track_button:&nbsp;<ins>&nbsp;Upgrade it with Undo()&nbsp;</ins></summary>

```csharp
using Reversible;

public class IndulgentChess<T> : Chess<T>, IUndoable
{
    IUndoable<T> _backup = UndoOnly.Empty<T>();
    override T _move { get => _backup.Value; set => _backup.Value = value; }

    void Undo(int steps = 1) => _backup.Undo(steps);
}
```

</details>

<details>
<summary>:popcorn:&nbsp;<ins>&nbsp;Show the usage&nbsp;</ins></summary>

```csharp
var game = new IndulgentChess<string> { Move = "d4" }; // white begin ...
game.Move = "Nf6"; // Indian Defence
game.Move = "c4"; 
game.Move = "0-1"; // a world champion would resign the game ...
game.Undo(); // ... but not you
game.Move("e6");
// ...
```

&nbsp;&nbsp;&nbsp;&nbsp;<sup>:information_source:</sup>&nbsp;<sub>Game sample inspired by [Champions Chess Tour 2022](https://en.wikipedia.org/wiki/Carlsen%E2%80%93Niemann_controversy)</sub>
</details>  

&nbsp;\
Next, the __[Handbook](readme+/handbook)__ will cover the vast of other features and use cases along with inspired [Q&A](readme+/reversible_q-a.md).

Your inevitable question... __Isn't that all an over-engineering of indexed element?__ <sup>:hammer:</sup>&nbsp; It's up to you to answer while [Rationale](readme+/reversible_reason.md) backed by [Posers & Decisions](readme+/reversible_posers.md) shall justify the efforts.\
&nbsp;&nbsp;&nbsp;&nbsp;<sup>:hammer:</sup><sub>For instance, `Moves[i]` for current value, `i--` for undo and `i++` for redo.</sub>

Code for the sample above is too trivial to deserve your look into the repository, but not the whole project, which you may follow in [Developer book](readme+/devbook), contribute to it or rework for own purposes.
