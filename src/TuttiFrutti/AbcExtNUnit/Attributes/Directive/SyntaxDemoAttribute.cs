﻿namespace AbcExtNUnit.Attributes.Directive;
public class SyntaxDemoAttribute : IgnoreAttribute
{
    public SyntaxDemoAttribute() : base("for demonstration only, may fail") {
        // Intentionally blank
    }
}