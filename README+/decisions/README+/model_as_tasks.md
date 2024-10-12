# Tasks as a model, promise as a value

Most or many well-known templates/paradigms, such as <samp><b>MVC</b></samp>, <samp><b>MVP</b></samp>, <samp><b>MVVM</b></samp>, <samp><b>MV<i>W</i></b></samp>[hatever], <samp><b>POCO</b></samp>, and custom solutions rest on [models](https://github.com/Kyriosity/read-write/blob/main/README%2B/software/design/parts/README+/app-model.md)<sup>⬅️</sup>. 

Developers bind presentations, actions, and messages to values/properties/callbacks. There's nothing wrong with this approach (especially for rough abstraction and logical division) but oversimplicity and static character (like snapped in a moment when every value is known).

Values can be predictably set/reset, or coded in a slot of time, imperceptible for users or insignificant for hardware/software clients. However, IT reality can imply

* heavy calculation,
* lagging services, and slow rudimentary storages,
* pending input (e.g. _Mittelspiel_ move in classic chess or vacation approval in non-classic startup),
* statuses linked to running actions (either naturally or intentionally pending).

And any operation can break, fail, or be suspended or canceled on both sides. 

Enough scenarios shall mock delays to catch user attention or show proof of work<sup>⏳</sup>. In some others, the possible (non)availability of value or its promise is itself the value (e.g. `CanExecute` for commands).

Classical, direct/async, and prevalent implementation incurs perpetual patching of unpredictable values for reactive  experience. 

Now, spice these reactive interfaces with `async`: you must break the queue of values into orchestration.

To make the thing worse recall that besides multitasking there's multi-dispatching (that's how auto-save, or spellcheck runs).

\_______\
&nbsp;&nbsp;&nbsp;&nbsp;<sup>⏳</sup> <sub>For example, saving a giga-document, rebuilding a solution, or making a bank transaction can occur unexpectedly instant for users.</sub>

## Re-thinking model and presentation

Modern languages and frameworks confer brilliant multitasking and synchro tools out-of-the-box. **Let's cast them to templates!**

> 🚧🚧🚧 <mark><b>... to be WRITTEN when PARTICULAR IMPLEMENTATION comes into play ...</b></mark> 🚧🚧🚧

## Appendices. Techniques

Some established techniques and tricks can still contribute to async thinking or spoil its implementation (since any pattern may conditionally become an antipattern).

### Caching

The most obvious and simplest to add technique. Only growing cache may concern but its size can be dramatically reduced when big parts are "hashed" and stored only once (floating window method to help). Along with easy-to-apply <samp>FIFO</samp>.

### Laziness (not of developers)

Since the olden days, programmers used to defer initialization/calculation of less or more "heavy" entities. This allows to **a)**&nbsp;load the stuff on&nbsp;demand only (eco-friendly), **b)**&nbsp;spread resources peaks, **c)**&nbsp;split suspense (which nevertheless remains).

<details><summary><ins>&nbsp;In <b>C#</b> you can do it either with <code>Lazy<...></code> or custom snippet like this:&nbsp;</ins></summary>
&nbsp;
  
  ```csharp
public BigAndHeavy Ram => _ram ?? LoadAndHit();
private BigAndHeavy? _ram;
  ```
\_______________
</details>

This technique looks attractive when <mark>$`(performance/hit)*probability`$</mark> is too low. Being advanced we may think of making an on-the-fly reevaluation of this formula to unleash the lazy, which implies a smart realization of the next technique - _preloading_.

#### Examples?

Consider custom number sequences (relying on previous values). The first must be easy to calculate unconditionally while attributing as lazy the next ones when it's getting harder to compute. When the computer is idle, next _lazy_ number gets calculated to have a reasonable supply (say of a hundred in sequence).

### Preloading: praise and critique

The power and storage even of home tablets are multiprocessor<sup>⚛️</sup>, multicore, excessive, and mostly idle<sup>:video_game:</sup>, while platforms like .NET, JVM, or browser engines, and any OS ensure the smooth background running of countless processes and threads.

The story has much reverted the _Lazy Loading_ - it's not crucial to delay tasks but to complete them as much as possible earlier and in the background, and then smoothly render results on demand.

It doesn't matter if you "pre-load" a dozen things, of which only one will be selected by the user (e.g. a next wizard page dependent on differing paths). Compare this to maintaining gross warehouses for a single well-founded purpose: to deliver goods within a day on customer orders.

&nbsp;&nbsp;&nbsp;&nbsp;<sup>⚛️</sup> <sub> There are at least three: main, math, and video.</sub>\
&nbsp;&nbsp;&nbsp;&nbsp;<sup>:video_game:</sup> <sub>Assumed: usual office, browsers, business applications, and dev environments (not high-performance servers, top games, video processing or mining).</sub>

**Eco-harmful?** Let's consider it when most blockchain mining farms are shut down.

### Streaming

Processing sync/async streams is a still fresh technique, which only requires a reference to its [foundation](https://github.com/ReactiveX)<sup>🔗</sup>.

\___________\
🔚 🌔 <sub>2024 .. kyriosity ... 🚧 pending 🚧</sub>
