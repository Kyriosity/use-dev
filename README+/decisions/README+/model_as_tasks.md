# Tasks as model

Most or many well-known templates/paradigms (MVC, MVP/MVVM, MV-Whatever, POCO) and custom solutions rest on models. 

Developers bind presentations, actions, and messages to values/properties. There's nothing wrong with this approach (especially for abstraction and logical division) but oversimplicity and static character.

Values can be not only unnoticeably loaded/changed but also calculated, rendered by a service, read from storage, and awaited from response/request (the latter can be suspended, canceled, or failed at all).

Direct implementation in reactive applications (which are not in this day and age?) incurs perpetual patching of lags to improve user experience. 

Many scenarios may mock delays to catch user attention or show proof of work.<sup>⏳</sup> In some others the possible (non)availability of value or a promise is a value by itself (e.g. `CanExecute` for commands).

Now spice the reactive interface with `async`: you must now break the queue of values into orchestration. EXAMPLE !

To make the thing worse recall that besides multitasking there's multi-dispatching (e.g. auto-save, spellcheck).

\_______\
&nbsp;&nbsp;&nbsp;&nbsp;<sup>⏳</sup>For example, users don't expect that saving the giga-document, rebuilding a solution, or reading from a distant server can be instant.

## New thinking

Modern languages and frameworks GRANT

PLACEHOlDER for PhD

LAYERING CODE TO MAKE ERRs UNFATAL

## Appemndices. Techniques

Behind presentations, there could be some tricks to make them even better or worse (since any pattern is antipattern too).

### Laziness (not of a developer)

Since the olden days, programers used to defer initialization/calculation of less or more "heavy" entities. This allows to **a)**&nbsp;load the stuff on&nbsp;demand only (eco-friendly), **b)**&nbsp;spread resources peaks, **c)**&nbsp;split suspense (which nevertheless remains).

THOUGH LAZY LOAD is still practical

In C# you can do it either with `Lazy<...>` or custom code like this:

<details><summary><ins>&nbsp;Deferred loading snippet&nbsp;</ins></summary>
&nbsp;
  
  ```csharp
public BigAndHeavy Ram => _ram ?? LoadAndHit();
private BigAndHeavy? _ram;
  ```
</details>

Nowadays it's ALSO an anti-pattern.

### As an "anti-pattern"

### Praise and critique of preloading

The power and storage even of home laptops are multicore, excessive, and mostly idle<sup>:video_game:</sup>, while platforms like .NET ensure the smooth background running of multiple processes.

The story got inverted Lazy Loading - it's not crucial to delay tasks but to complete them as much as possible earlier and in the background, and then seamlessly produce results when asked.

It doesn't matter if you "pre-load" a dozen things, of which only one will be selected by the user (e.g. next wizard page dependent on differing paths). Compare to warehouses, where it costs to keep a supply of goods, for a single purpose to be delivered within a day when the customer orders.

&nbsp;&nbsp;&nbsp;&nbsp;<sup>:video_game:</sup> <sub>Assumed: usual office, browsers, business applications, and dev environments (not high-performance servers, top games, video processing or mining).</sub>

ECO-FRIENDLY ANTONYM? Let's conisder if after the last mining farm is CLOSED.

#### Caching

### Streaming (not on YouTube 🍨🌹)

Processing sync/async streams is a relatively fresh technique, which only requires a reference to its [foundation](https://github.com/ReactiveX)<sup>🔗</sup>.

🔚 🌔 2024 Kyriosity ... 🚧 work in (slow) progress 🐝
