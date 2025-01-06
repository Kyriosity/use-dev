# P<samp>atterns via techniques</samp> &mdash; Circuitry

It's the case when _inductive reasoning_ is better (namely by an example). Let's begin, considering a bundle of interlaced "either"-functions:

<div align="right"><sub><i>C#-like pseudo-code for brevety</i></sub></div>

```csharp
class Is {
  string _text;

  bool NullOrEmpty => _text is null || ' == _text;
  bool NullOrWhitespace { ... };
  bool Ascii { ... };
  bool Latin { ... };
  bool AlphaNumeric { ... };
}

```

and there's a client that needs these functions exactly as **`neither`**. Since there's no magic and out-of-the-hat 🪄 _Boolean Inverter_ the fastest way will be to put the wrapper over:

```csharp
class Not : Is {
  override NullOrEmpty => !NullOrEmpty;
  override NullOrWhitespace => NullOrWhitespace;
  override Ascii => !Ascii;
  override Latin => !Latin;
  override AlphaNumeric => !AlphaNumeric;
}
```

This and other alternatives, discussed in the [Appendix](#appendix), are too programmatic.

GOES BEYOND SIMPLE LINEAR

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

## <a id="why-circuitry" /> Wrap up. Why "circuitry"?

<table><tr valign="top"><td width="40%"><img alt="&nbsp;electrical circuit collage" src="../../../_rsc/img/illus/Circuitry.jpg" /></td><td>
  <p>You may have already noticed the similarities of the proposed solution to electronic circuit the name.</p>
  <p>Didifal is only for `boolean`.</p>
</td></tr>
</table>

## Appendix. Alternatives

<a id="appendix" />

### Wrapper class

### Pros 

### Const

HAVE YOU NOTICE A TYPO i INTENTIONALLY LEAVED ? I personally don't like such wrappers.

🔚
