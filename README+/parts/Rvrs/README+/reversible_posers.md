# Reversible &mdash; Posers

> Discussion in this and other documents will rest on selected [design samples](https://github.com/Kyriosity/read-write/tree/main/README+/software/design/samples).

Reflexion on Undo/Redo sooner or later will baffle one with the following dilemmas and challenges. You shall not consider them as dev tasks or a knowledge quiz but as clarification of the "big picture".

## _Value_ or/and _action_ dilemma

Chess is a perfect example where the sequence of changes can be stored either as moves (actions) or board alteration (value). A move results in a board alteration.

## Point of no undo

Here chess serves us again as a good example. Let's take a game of `n` moves of white and black pieces and imagine the initial point to which we can undo the setup of pieces and their moves.

Depth and buffer.

## Breaking long actions into steps

To illustrate the idea. Imagine you make a long artistic stroke in _Paint_ with an occasional ugliness at the end. Undo will delete the whole stroke.

## Action error, its margin and tolerance

Consider the square root and its inverse function _x2_.

## Repetitions and patterns

E.g. math sequences, or the same function but with different arguments.

## Beyond the scope

The following considerations and their solutions do not belong to the _Reversible_.

### Huge subjects

### Streaming/debouncing

... 🚧 TO BE CONTINUED 🚧...
