# Guidelines &mdash; Communcation &mdash; Errors

## Limitations

### Not Implemented / Not Supported / Invalid Operation - are not "true" exceptions and not for clients

There are languages native<sup>🌩️</sup> and customs exceptions/errors, which programs can raise to tell that a method/feature/module is under development, delayed or its call/parameters are deprived of sense (under certain conditions).\
&nbsp;&nbsp;&nbsp;&nbsp;<sup>🌩️</sup> <sub>[`NotImplementedError`](https://docs.python.org/3/library/exceptions.html) in Python,
 [`UnsupportedOperation`](https://docs.oracle.com/en/java/javase/17/docs/api/java.base/java/lang/UnsupportedOperationException.html) in Java or
 [`NotImplemented`](https://learn.microsoft.com/en-us/dotnet/api/system.notimplementedexception), [`NotSupported`](https://learn.microsoft.com/en-us/dotnet/api/system.notsupportedexception), and
 [`InvalidOperation`](https://learn.microsoft.com/en-us/dotnet/api/system.invalidoperationexception) in C#.</sub>

They can "**stub**" calls or serve as bookmarks for work-in-progress, and other developers will accept them as a replacement for crude `//ToDo`_s_ or as an excuse for logic incompleteness/coding litter. 

<table><tr valign="top">
  <td width="30%"><picture><img src="https://github.com/Kyriosity/read-write/blob/main/README%2B/_rsc/_img/snap/screen/MsgBox-NotImplemented-sample.jpg" 
       alt="&nbsp;Messagebox with not implemented error" title="&nbsp;Screen capture from Anonymous.&#013;&#010;(Product title under the blur of charity.)" /></picture></td>
<td>
<p>What's decent for developers is not for clients. Because of the enigmatic character when released.</p> 
<p>Users get fake UI actions enabled, an API provides ghost methods or a request has just worked (with these or those parameters).</p>
<p>The ugly error message box is the last thing (after a crash) users love to see.</p>
</td>
</tr></table>

#### Alternatives

* Disable or, if UI, provide an explanation message (though also not great).
* Design return value that envisages errors.
* In conditional cases: raise a sort of _Argument Exception_.
* **Most exotic**: implement.

🔚 ... to be continued 🐝 ...
