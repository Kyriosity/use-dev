﻿namespace AbcShortcutsTests.Text.Usual.Plus;
public class Demo
{
    [Test]
    public void BlankTraits() {
        const string nullText = null;

        Assert.That(
            nullText.IsNullEmptyOrSpaces() && "".IsNullEmptyOrSpaces() &&
            " ".IsNullEmptyOrSpaces() && "    ".IsNullEmptyOrSpaces() && !"test".IsNullEmptyOrSpaces(),
    Is.True);

        Assert.That(
            nullText.IsNullEmptyOrSingleSpace() && "".IsNullEmptyOrSingleSpace() &&
            " ".IsNullEmptyOrSingleSpace() && !"    ".IsNullEmptyOrSingleSpace() && !"test".IsNullEmptyOrSingleSpace(),
        Is.True);
    }
}

[Obsolete]
static class Plus
{
    public static bool IsNullEmptyOrSingleSpace(this string? value) => string.IsNullOrEmpty(value) || " " == value;
    public static bool IsNullEmptyOrSpaces(this string? value) => string.IsNullOrEmpty(value?.Trim());
}