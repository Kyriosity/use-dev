# Reversible &mdash; Keeping undo for big data objects

## Background

Piling a series of primitive values (numbers, bool) is plain. But consider huge and/or composite stuff:
+ hi-res bitmap image,
+ long text with formatting,
+ large binary data,
+ sophisticated business records

It would be a memory/performance hit to store a copy for frequent changes like retouching some pixels on telescope panorama or editing even this doc.

A large bitmap is pretty illustrative. Well, we can store only the changed area, but imagine also operations which are just one word but completely "change the picture":
+ flip and rotate,
+ resize/resample,
+ adding some space, 
+ fill with a solid color / erase.

## Scripted changes

TO BE DEVELOPED

## Alternatives

+ On-the-fly compression/archiving could be a fast and easy solution.
+ Bits-level hashing.
+ There're must be 3d-parties ready solutions.

🔚
