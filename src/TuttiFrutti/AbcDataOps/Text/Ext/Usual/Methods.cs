namespace AbcDataOps.Text.Ext.Usual;
public static class Methods
{
    public static bool IsNullOrEmpty(this string? value) => string.IsNullOrEmpty(value);
    public static bool IsNullOrWhiteSpace(this string? value) => string.IsNullOrWhiteSpace(value);
    public static string? IsInterned(this string value) => string.IsInterned(value);

}

public static class Plus
{
    public static bool IsNullEmptyOrSingleSpace(this string? value) => string.IsNullOrEmpty(value) || " " == value;
    public static bool IsNullEmptyOrSpaces(this string? value) => string.IsNullOrEmpty(value?.Trim());
}
