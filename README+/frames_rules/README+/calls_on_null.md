# Calls on `null`

## Short intro

You expect this snippet to throw `NullReference`&nbsp;**.**&thinsp;**.**&thinsp;**.**

```csharp
bar.DoSometing();
bar = null; // IT'S NOW NULL!
bar.DoSomething();
Console.WriteLine("now you see me");
```

**.**&thinsp;**.**&thinsp;**.**&nbsp;but miscellaneous languages can do the trick. For example, extension methods (and one fine day properties) in **`C#`**.

## Use or abuse?

Continuation on `null` looks worse than [its billion-dollar mistake](https://www.infoq.com/presentations/Null-References-The-Billion-Dollar-Mistake-Tony-Hoare)<sup>🔗</sup>. 

**Yes** ... and **no**, if the semantics and job of the dot attachment assume this `null`. 

```csharp
void JustDemo(string? title, INumber<N>? id, Person? person) {
    title.INotNullOrWhitespace();
    id.IsNaturalNumber();
    person.IsNullOrDefault();

  //Everything else up to your phantasy
}
```

// ToDo: LINK TO STR EXT when available

🔚

NOT IMPLEMENTED is // ToDo?
