namespace AbcStuff.Test.String;

public class Whitespaces : IConstsSource
{
    public const string PureSpaces = "                     ";
    public const string TwoLiner = "         \n       ";
    public const string Multiline = @"         
        
        
        ";

    public readonly string NOTFORTEST = "";

    public class Mix : IConstsSource
    {
        public static readonly string WithSymbols = $"  {Char.ParagraphSeparator}   {Char.CharacterTab}  {Char.FormFeed}  ";
        public static readonly string WithAltSpaced = $"    {Spaces.Char.Thin}   {Spaces.Char.FourPerEm}     ";
        public static readonly string TuttiFrutti = $" {Char.CarriageReturn}   {Spaces.Char.FourPerEm}      ";
    }

    public class Char : IConstsSource
    {
        public const char NewLine = '\n';
        public const char CarriageReturn = '\r';
        public const char LineSeparator = '\u2028';
        public const char ParagraphSeparator = '\u2029';
        public const char CharacterTab = '\u0009';
        public const char LineTab = '\u000B';
        public const char LineFeed = '\u000A';
        public const char FormFeed = '\u000C';
        public const char NextLine = '\u0085';
    }
}

public class Spaces : IConstsSource
{
    public const string Single = " ";
    public const string Double = "  ";
    public const string Triple = "   ";
    public const string Multiple = "                                   ";

    public class Mix : IConstsSource
    { }

    public class Char
    {
        public const char Ascii = ' ';
        public const char NonBreaking = '\u00A0';
        public const char Ogham = '\u1680'; // Irish
        public const char EnQuad = '\u2000';
        public const char EmQuad = '\u2001';
        public const char En = '\u2002';
        public const char Em = '\u2003';
        public const char ThreePerEm = '\u2004';
        public const char FourPerEm = '\u2005';
        public const char SixPerEm = '\u2006';
        public const char Figure = '\u2007';
        public const char Punctuation = '\u2008';
        public const char Thin = '\u2009';
        public const char Hair = '\u200A';
        public const char NarrowNoBreak = '\u202F';
        public const char MediumMath = '\u205F';
        public const char Ideographic = '\u3000';
    }
}

public class Grayspaces : IConstsSource // PUNCTUATION OR ?
{
}