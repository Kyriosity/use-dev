# P<samp>atterns via Techniques</samp> &rarr; Circuitry

> «C<samp>IRCUITRY</samp>» like many other ideas is better presented by _inductive reasoning_ &mdash; namely by an example as below.

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

class Is<Fn> : Is where Fn : Function<bool, bool> {
   override NullOrEmpty => Fn(NullOrEmpty); // CAN DO by REFLECTION TOO!
}

class Not : Is<Invert>;
class Denier : Is<False>;
class Stub : Is<True>;
class Identity : Is<Wire>; 


```

DYNAMIC FILL OUT

CONSTRUCTOR (VIOLATES)
   PROPS => EXPOSED


// Illustration pending

It's the case going. Consider a class that 

why not 
constructors, init props, or derived classes?

## Circuitry thru markup

## <a id="why-circuitry" /> Why "circuitry"?

<table><tr valign="top"><td width="40%"><img alt="&nbsp;electrical circuit collage" src="../../../_rsc/img/illus/Circuitry.jpg" /></td><td>
  <p>You may have already grasped the similarities of the proposed solution to electric and electronic circuits and boards.</p>
  <ul>
  <li>Logic gate is for `booleans`.</li>
  <li>Digital is only for `numbers`.</li>
   <li>Analog for strings and other objects.</li>
  </ul>
  <p>And generic "markup" is like plugging elements into circuits of a functional plate.</p>
</td></tr>
</table>

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

🔚
