namespace AbcDataOps.Text.Relate;
public class Mid
{
    internal Mid(bool leftNotRight, string source, StringComparison comparison) {
        _leftNotRight = leftNotRight;
        _source = source;
        _comparison = comparison;
    }
    private readonly bool _leftNotRight;
    private readonly string _source;
    private readonly StringComparison _comparison;

    public static bool operator ==(Mid obj, string operand) => Match(obj._leftNotRight, obj._source, operand, obj._comparison);
    public static bool operator !=(Mid obj, string operand) => !Match(obj._leftNotRight, obj._source, operand, obj._comparison);


    private static bool Match(bool leftNotRight, string whole, string part, StringComparison comparison) {
        var wholeLen = whole.Length;
        var partLen = part.Length;

        if (wholeLen < partLen)
            return false;

        var toMatch = wholeLen == partLen ? whole : whole.Substring(
            leftNotRight ? 0 : wholeLen - partLen, partLen);
        return toMatch.Equals(part, comparison);
    }
}