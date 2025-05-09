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

Continuation on `null` may look worse than [its billion-dollar mistake](https://github.com/Kyriosity/read-write/blob/main/README%2B/pencraft/README%2B/essays/README+/NullRefError.md).  
Correct ... **unless** the semantics and job _after dot_ assume this `null`:

```csharp
void JustDemo(string? title, N? id, Book? book) where N : INumber<N> {
    title.NullOrWhitespace();

    id.Is.NullOrZero();
    id.Not.NullOrGreaterThan(100);
    id.IsNaturalNumber(); // will throw if null

    book.IsNullOrDefault();

  //Everything else up to your fantasy
}
```

### References

[<samp>⭐<b>ISie</b>⭐</samp>&nbsp; extensions](../../parts/_ext/ISie/README.md) checks run on nullable things.

\___________\
🔚 .. 2024-2025 .. please share similar solutions in other languages you may know ...

