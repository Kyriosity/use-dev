# P<samp>atterns via Techniques</samp>&nbsp;&nbsp;&mdash;&nbsp;&nbsp;Object-oriented Circuitry

> «C<samp>IRCUITRY</samp>» as an idea is better presented by _inductive reasoning_ &mdash; from a case below.

Consider a bundle of interlaced "_either_"-functions:

<div align="right"><sub><i>C#-like pseudo-code for brevity</i></sub></div>

```csharp
class Is {
  string _text;

  bool NullOrEmpty => _text is null || '' == _text;
  bool NullOrWhitespace { ... };
  bool Ascii { ... };
  bool Latin { ... };
  bool AlphaNumeric { ... };
}

```

and there's a demand for them (functions) as **`neither`**. Since there's no magic out-of-the-hat 🪄 _Boolean Inverter_ the most predictable way will be a wrapper over:

```csharp
class Not : Is {
  override NullOrEmpty => !NullOrEmpty;
  override NullOrWhitespace => !NullOrWhitespace;
  override Ascii => !Ascii;
  override Latin => !Latin;
  override AlphaNumeric => !AlphaNumeric;
}

// or an Adapter aggregating class when methods aren't virtual
```

It's not a single option (see other variants in the [Appendix](#alternatives)) **but what if** instead of a "programmatic" approach, we propose a kind of 
<samp><mark>declarative markup</mark></samp>.

```csharp

class Is<Fn> : Is where Fn : Function<bool, bool> {
   override NullOrEmpty => Fn(NullOrEmpty);
   ...
}

class Not : Is<Invert>;
class Denier : Is<False>;
class Stub : Is<True>;
class Identity : Is<Wire>; 

```

Even this simple unary boolean has four variants, while other types are more combinatory and appealing:

+ Bring your own algorithm:\
`"some string".Equals<Loose>(CompareOptions.IgnoreCase);`

+ Lingua\
text.Is<French, Latin>.Alphanumeric;

+ Numbers
Random<ALGORITHM>.Within(1, 100)

+ Objects

<details><summary><a id="why-circuitry" /><ins>&nbsp;&nbsp;&nbsp;<b>Lyric Digression: Why "Circuitry"&thinsp;?</b>&nbsp;&nbsp;&nbsp;</ins></summary>

<table><tr valign="top"><td width="40%"><img alt="&nbsp;electrical circuit collage" src="../../../_rsc/img/illus/Circuitry.jpg" /></td><td>
  <p>You may have already grasped the similarities of the proposed solution to electric and electronic circuits and boards.</p>
  <ul>
  <li>Logic gate is for `booleans`.</li>
  <li>Digital is only for `numbers`.</li>
   <li>Analog for strings and other objects.</li>
  </ul>
  <p>And generic "markup" is like plugging elements into circuits of a functional plate.</p>
  Chaining, cascading, IO
</td></tr>
</table>

\___________</details>

## Pros and cons

✅ First of all, the split of design in a good way.

🛑 Overengineering

## Implementations

Alas. there's no Func constraint in C# (DELETGATE doesn't help)

## Wrap up. Do not abuse

"Circuitry" shall patch parts where  This approach may smoothly lead back to machine language.

BACK TO ROOTS

## Appendix. Alternatives<a id="alternatives" />

### Dynamic Majic Wand

You can build your magic wand with dynamic programming (e.g. Roslyn for C#).

```csharp

var notOptions = Invert<Is>();

{
  T Invert<T><S boolie) where S : T;
}


```

#### Cons

Run-time assembled code is worse to debug.

### Wrapper class

### Pros 

### Const

HAVE YOU NOTICE A TYPO i INTENTIONALLY LEAVED ? I personally don't like such wrappers.

🔚 🌘 2024-2025
