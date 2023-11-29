namespace Code.Setup.Validation;
public static class Guard
{
    public static class Args
    {
        public static bool VsType(string typeInfo, out string msg, params (string val, bool isValid)[] args) {
            if (args.All(x => x.isValid)) {
                msg = "valid";
                return true;
            }

            var invalid = args.Where(x => !x.isValid).Select(x => x.val);
            msg = 1 < invalid.Count() ? $"neither '{string.Join("\' nor \'", invalid)}' match" :
                $"\'{invalid.First()}\' doesn't match";
            msg += $" \"{typeInfo}\" ({invalid.Count()}/{args.Count()})";

            return false;
        }

        public static bool VsType<T>(out string msg, params (string val, bool isValid)[] args) {
            var ofType = typeof(T);
            return VsType($"{ofType.Namespace}.{ofType.Name}", out msg, args);
        }
    }
}
