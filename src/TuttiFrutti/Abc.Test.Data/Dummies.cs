namespace Abc.Test.Data;

public static class Dummies
{
    public static class Text
    {
        public const string PangramEn = "the quick brown fox jumps over the lazy dog";

        public const string LoremIpsum = "Lorem ipsum dolor sit amet consectetur adipiscing elit sed do eiusmod tempor " +
            "incididunt ut labore et dolore magna aliqua " +
            "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex " +
            "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur " +
            "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum";
    }

    public static class Sequences
    {
        public static readonly int[] ZeroToEleven = Enumerable.Range(0, 12).ToArray();
    }
}
