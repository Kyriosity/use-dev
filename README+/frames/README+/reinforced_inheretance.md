# Vertical rebars - Reinforced inheritance or logic flow

<table><tr></tr><tr><td>☝️</td><td>
  This frame isn't a rule of thumb but a proposal for our consideration in matching circumstances.
</td></tr></table>

<table><tr valign="top">
<td width="40%"><picture><img src="https://github.com/Kyriosity/read-write/blob/main/README%2B/_rsc/_img/photo/misc/rebar_closeup.jpg" alt="&nbsp;rebar closeup" title="&nbsp;Image credit: Wiki Commons&#013;&#010;(for illustration purposes only)" /></picture></td><td>
 <p><ins>&nbsp;Look at the following approach:&nbsp;</ins></p>
  <ol>
  <li><code>Public</code> methods are non-<code>abstract</code> and limited to the <b>logic flow</b> not delving into implementation details.<br />(Call operations, branch, get and pass values, handle and raise exceptions)</li>
  <li><b>Implementation</b> is delegated to non-public (<code>private</code>, <code>protected</code>, <code>internal</code>) methods, which these public "dispatchers" call.</li>
  <li><code>Public</code> methods are "<b>sealed</b>" (non-virtual, not to override).</li>
  <li>Non-public implementation methods can be <b>virtual</b> (get overridden).</li>
  <li><ins>Optional:</ins> implementation methods do not interact with each other.</li>
</ol>
  <p><b>Derived classes will have to follow the "armature".</b></p>
  <p dir="rtl"><mark>.You may notice a touch of functional programming in this approach</mark></p>
</td>
</tr></table>

```csharp
public class Sample {
    public Main() {
      Guard();
      if (PredicateA())
          var a = DoA();
          DoNext(a);
      try {
      }
      catch() {
          /// 
      }
    }
}
```

Besides discipline, order, and readability this frame makes classes friendly to functional parametrization (that's irrelevant to inheritance):

+ parametrizing object with subfunctions;
+ dynamic programming of sub-calls;
+ casting between objects;

**What about properties?** Treat their getters and setters as `public` methods.

## Contraindications

It will be a surplus for simple `classes` or short methods.

The logic of implementation may be too ornate for straight frames.

It's not friendly to the functional approach to implementation.

🔚
