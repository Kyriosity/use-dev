# P<samp>atterns _via_ Techniques:</samp> Object-oriented C<samp>IRCUITRY</samp>

## Inductive Reasoning for Intro

let's present the idea through a case study.

> __«C<samp>IRCUITRY</samp>» as an idea is better presented by _inductive reasoning_ &mdash; from a case below.__

Consider a bundle of interlaced "_either_"-functions:

<div align="right"><sub><i>C#-like pseudo-code for brevity</i></sub></div>

```csharp
class Is {
  string subject;

  bool NullOrEmpty => subject is null || '' == subject;
  bool NullOrWhitespace { ... };
  bool Ascii { ... };
  bool Latin { ... };
  bool AlphaNumeric { ... };
}

```

and there's a demand for these functions as **`neither`**.

When there's no magic out-of-the-hat<sup>🪄</sup> _Boolean Inverter_ a predictable realization will be a wrapper:

```csharp
class Not : Is {
  override NullOrEmpty => !NullOrEmpty;
  override NullOrWhitespace => !NullOrWhitespace;
  override Ascii => !Ascii;
  override Latin => !Latin;
  override AlphaNumeric => !AlphaNumeric;
}
```

**But what if** instead of this and other evident "programmatic" realizations, we offer a kind of <samp><mark>&thinsp;declarative plugs&thinsp;</mark></samp>?

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

This simplest _unary boolean_ has four variants &mdash; other types with more than one operand will reveal an enormous space of ... 

<h2 align="center">... opportunities, to propose a few:</h2>

### Bring your own function:

<table><tr></tr><tr align="center"><td><b>Template</b></td><td><b>Use</b></td></tr><tr valign="top"><td>
    <code><i>Bag</i> diff&lt;<b><mark>T</mark></b>&gt; = <br />&nbsp;&nbsp;&nbsp;&nbsp;
      <mark>T</mark>Compare&lt;T, <mark>Fn</mark>&gt;(<b><mark></mark>T</b> sample, CompareOptions options)</code><br />
&nbsp;&nbsp;&nbsp;where,
<ul>
<li><code>Bag</code> collects differences (of possibly different types) as <a href="../../../../src/TuttiFrutti/AbcStructTests/Heaps">collection</a>,</li>
<li><code><b>T</b></code> is the type which instances are extended,</li>
<li><code><b>Fn</b></code> defines a function performing the extension.</li>
  </ul>
</td><td>

```csharp

"yada yada".Compare<LooseContent>("blah blah",
   CompareOptions.IgnoreCase);

```

&nbsp;&nbsp;&nbsp;where,

`LooseContent` means a compare function that ignores\
whitespace and punctuation 

</td><tr></tr><tr valign="top"><td>

```csharp
N num = MATH_FUNC<ALGORITHM>.Within<N>(from, to);
```

</td><td>

```csharp
int rnd = Random<DiceRole>.Within(1, 6);
```

```csharp
N hash = Hash<FISH>.Within<N>(from, to);
```

</td>
</tr></table>

### Lingua

Alphabet (rules)

```csharp
text.Is<Greek, Latin>.Alphanumeric;
```

### Custom objects

### <sup>🪄</sup>Dynamic "Majic Wand"

This must be the most powerful and controversial proposition.

<table><tr></tr><tr align="center"><td><samp><b>Template</b></samp></td><td>Use</td></tr><tr valign="top"><td>

```csharp
custom_object.Return<Fn>.For<IScope>();

ALL_IN

Fn - defines type

.Input<Fn>

```

</td><td>
  
</td></tr></table>

<details><summary><a id="why-circuitry" /><ins>&nbsp;&nbsp;&nbsp;<b>Now the electrical metaphor must have taken shapes&thinsp;:</b>&nbsp;&nbsp;&nbsp;</ins></summary>

<table><tr valign="top"><td width="40%"><picture><img alt="&nbsp;electrical circuit collage" src="../../../_rsc/img/illus/Circuitry.jpg" /></picture></td>
<td>
  <p>You may have already grasped the similarities of the proposed solution to electric and electronic circuits and boards.</p>
  <ul>
  <li><code>Booleans</code> match logic gates .</li>
  <li><code>Numbers</code> &mdash; digital circuits.</li>
   <li><code>string</code> and classes are analogue electronics.</li>
  </ul>
  <p>Generic "markup" is like plugging elements on IO or onto circuits of a functional plate: direct, chaining, cascading, ...</p>

Classes are PLATES to make BOARDS.
  
  <p>And the running code is the current. We are back to the roots (of machine language).</p>
</td>
</tr></table>

\___________</details>

## Wrap up

experimental

## Pros and cons

✅ First of all, the split of design in a good way - as a side abstraction or track of logics.

comes hand in hand with generic parametrization. LINK !!

the main logic remains intact.

+ Declarative language is friendlier for comprehension.

TEMPLATING 

+ sharing. impulse to of elements. invert, multilingual trim are obvious

declarative is plus

Design-first will create a test structure that is friendly for exploration and introduction of applications and features (even for non-developers).

🛑 Overengineering

🗝️🕰️ implementation obstacles 

**`C#`** doesn't have `Func` generic constraint to be patched
 (DELETGATE doesn't help)


## Appendix. Implementation cases

ISIe

\___________\
🔚 🌘 2024-2025
