# Calls on `null`

## Short intro

You expect this snippet to throw `NullReference`&nbsp;**.**&thinsp;**.**&thinsp;**.**

```csharp
bar.DoSometing();
bar = null; // IT'S NOW NULL!
bar.DoSomething();
Console.WriteLine("now you see me");
```

**.**&thinsp;**.**&thinsp;**.**&nbsp;but miscellaneous languages can do the trick. For example, extension methods (and one fine day [properties](https://github.com/dotnet/roslyn/issues/11159)<sup>:octocat:</sup>) in **`C#`**.

## Use or abuse?

Continuation on `null` looks worse than [its billion-dollar mistake](https://www.infoq.com/presentations/Null-References-The-Billion-Dollar-Mistake-Tony-Hoare)<sup>🔗</sup>. 

**Yes** ... unless the semantics and job of the dot attachment assume this `null`. 

```csharp
void JustDemo(string? title, N? id, Book? bpok) where N : INumber<N> {
    title.NotNullOrWhitespace();
    id.IsNaturalNumber();
    book.IsNullOrDefault();

  //Everything else up to your phantasy
}
```

### Working samples 

// ToDo: LINK TO STR EXT when available

\___________\
🔚 .. please share similar solutions in other languages you may know ...

