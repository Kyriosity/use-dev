# Intercom &thinsp;&mdash;&thinsp; Errors, Exceptions, and Fails

🚧🚧🚧 ... DRAFT ... 🚧🚧🚧

## Common mispractices and challenges

Solutions:

```csharp

throw new ArgumentException(INNER);

```

+ wrapping into specific exception (CODE E.G.)
+ INNER
+ TAG in the MESSAGE (`exc.`)

LINK TO THE DESIGN DECISIONS

#### Extra own _vs._ not recommended

Before throwing an exception


### Catching w/out respect to origin

#### NullPointer softpedalling
