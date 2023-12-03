namespace Meas.Units.Names.Si;

public static class Base
{
    public readonly static Dictionary<string, string> NameAbbr = new(StringComparer.InvariantCultureIgnoreCase) {
        {  "meter", "m" },
        {  "second", "s" },
        {  "gram", "g" },
        {  "ampere", "A" },
        {  "Kelvin", "K" },
        {  "mole", "mol" },
        {  "candela", "cd" },
    };
}
