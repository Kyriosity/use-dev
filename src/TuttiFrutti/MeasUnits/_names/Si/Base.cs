namespace MeasUnits.Names.Si;

public static class Base
{
    public static readonly Dictionary<string, string> NameAbbr = new(StringComparer.InvariantCultureIgnoreCase) {
        {  "meter", "m" },
        {  "second", "s" },
        {  "gram", "g" },
        {  "ampere", "A" },
        {  "Kelvin", "K" },
        {  "mole", "mol" },
        {  "candela", "cd" },
    };
}
