# Unit tests &mdash; Gradual assert

Despite our preferences for programming languages and frameworks, we are used to categorical feedback from tests: either 🟢**success** or 🔴**fail**. 

The majority of tests don't ask for more and many developer may never need anything else but there are other stories with vague and changeable criteria:

- Precision of calculations/deviations,
- Performance (execution time and other resource consumption),
- Strength of algorithms (encryption).


The same applies to negative results. "Not great and not terrible".

## Issue

Neither public test frameworks, as far as I know them, don't support shades of green and red. This could be a star rating, or 1-10 scale, or percent.

⭐⭐⭐



### Workaround



[Funcware tests](../../../src/TuttiFrutti/Funcstore.Convert.Tests/)

Variable criteria.

🔚
