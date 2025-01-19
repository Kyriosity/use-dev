# Calls legally running on `null`

**Expected:** this snippet to throw `NullReference`&nbsp;**.**&thinsp;**.**&thinsp;**.**

```csharp
Bar bar = new Bar();
bar.DoSometing();
bar = null; // IT'S NOW NULL!
bar.DoSomething();
Console.WriteLine("now you see me");
```

**.**&thinsp;**.**&thinsp;**.**&nbsp;**but** miscellaneous languages can do the trick. For **`C#`** example, [extension methods](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods)<sup>🪟</sup> (and one fine day [properties](https://github.com/dotnet/roslyn/issues/11159)<sup>:octocat:</sup>).

## Use or abuse?

Continuation on `null` may look worse than [its billion-dollar mistake](https://www.infoq.com/presentations/Null-References-The-Billion-Dollar-Mistake-Tony-Hoare)<sup>🔗</sup>.  
Correct ... **unless** the semantics and job _after dot_ assume this `null`:

```csharp
void JustDemo(string? title, N? id, Book? book) where N : INumber<N> {
    title.NullOrWhitespace();

    id.Is.NullOrZero();
    id.Not.NullOrGreaterThan(100);
    id.IsNaturalNumber(); // will throw if null

    book.IsNullOrDefault();

  //Everything else up to your phantasy
}
```

### References

[<samp><b>I&thinsp;S&thinsp;i&thinsp;e</b></samp>&nbsp; extensions](../../parts/_ext/ISie/README.md) checks run on null.

\___________\
🔚 .. 2024-2025 .. please share similar solutions in other languages you may know ...

