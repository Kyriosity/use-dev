using AbcStuff.Test;

namespace AbcStuff.Text;

public class Whitespaces : IConstsSource
{
    public const string PureSpaces = "                     ";
    public const string TwoLiner = "         \n       ";
    public const string Multiline = @"         
        
        
        ";

    public readonly string NOTFORTEST = "";

    public class Mix : IConstsSource
    {
        public static readonly string WithCodes = $"  {Char.ParagraphSeparator}   {Char.CharacterTab}  {Char.FormFeed}  ";
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
