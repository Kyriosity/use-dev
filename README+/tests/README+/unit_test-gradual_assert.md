# Unit tests &mdash; Gradual assert

<table><tr valign="top"><td width="40%"><picture><img alt="&nbsp;Passed🟩: 388, failed🟥: 165. Not great, not terrible." 
 src="https://github.com/Kyriosity/read-write/blob/main/README%2B/_rsc/_img/memes/Tests-NotGreatNotTerrible.jpg" /></picture>
 </td><td>
<p>Despite our preferences for programming languages and frameworks, we are used to categorical feedback from tests:<br/>
either 🟢<b>success</b> or 🔴<b>fail</b>.</p>
The majority of proofs don't ask for more and many developers may never need anything else but there are other stories with fuzzy and changeable criteria:

* precision of calculations/deviations,
* performance (execution time and other resource consumption),
* strength of algorithms (encryption).

Another aspect is a negative result. The failure on a specific return value can indicate:

* small deviation from the expected interval,
* huge deviation,
* fully unexpected result,
* sudden exception,
* timeout,
* irrelevant error (e.g. connection, drive, etc.).
 
<p>Here empty methods and tests for expected exceptions look to be the only unequivocal.</p>
</td></tr></table>

## Issue

To my knowledge, neither public test framework supports shades of green and red. This could be a star rating (★★★☆☆), a `1`-`10` scale, or a percent. 

## Workaround

There are no magic solutions to adjust the frameworks. The following options can make it fast but not elegant:

+ programmatically setting auxiliary test statuses: e.g. [`Inonclusive`](https://learn.microsoft.com/en-us/dotnet/api/nunit.framework.assert.inconclusive?view=xamarin-ios-sdk-12) to indicated not exact but passing result, 
+ printing relative results with available symbols\
for example [Funcware tests](../../../src/TuttiFrutti/FuncStore.Convert.Tests/)

🔚 ... <sub>Image credit: screenshot of Visual Studio; screenshot of HBO mini-series, 2019</sub>
