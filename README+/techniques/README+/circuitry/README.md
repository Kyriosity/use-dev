# P<samp>atterns via Techniques</samp> &rarr; Circuitry

«C<samp><i>IRCUITRY</i></samp>» like many other ideas is better presented by _inductive reasoning_ &mdash; namely by an example as below.

Consider a bundle of interlaced "_either_"-functions:

<div align="right"><sub><i>C#-like pseudo-code for brevety</i></sub></div>

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

and there's a need for them (functions) as **`neither`**. Since there's no magic out-of-the-hat 🪄 _Boolean Inverter_ the most predictable way will be a wrapper over:

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

Other variants are reviewed in the [Appendix](#alternatives) but <b><samp>what if</samp></b> instead of a "programmatic" approach, we implement a kind of declarative markup.

```csharp

class Is<Fn> where Fn : Function<bool, bool> {
   bool NullOrEmpty => _text is null || '' == _text;
}

class Is : Is<Wire>;
class Not : Is<Inverse>;

class Stub : Is<True>

```

How's that?

\__________________________________________________________________________________________________________________


DYNAMIC FILL OUT

CONSTRUCTOR (VIOLATES)
   PROPS => EXPOSED

It was CIRCUITRY BUT WHY WAND?


is an EXPERIMENTAL technique

// Illustration pending

It's the case going. Consider a class that 

why not 
constructors, init props, or derived classes?

## Circuitry thru markup

## <a id="why-circuitry" /> Why "circuitry"?

<table><tr valign="top"><td width="40%"><img alt="&nbsp;electrical circuit collage" src="../../../_rsc/img/illus/Circuitry.jpg" /></td><td>
  <p>You may have already noticed the similarities of the proposed solution to electric and electronic circuit and boards</p>
  <p>Didifal is only for `boolean`.</p>
</td></tr>
</table>

## Implementations



## Wrap up. Do not abuse

Remember the quote of von Neuman ?
Everything can be presented as digital elements 

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



### Wrapper class

### Pros 

### Const

HAVE YOU NOTICE A TYPO i INTENTIONALLY LEAVED ? I personally don't like such wrappers.

🔚
