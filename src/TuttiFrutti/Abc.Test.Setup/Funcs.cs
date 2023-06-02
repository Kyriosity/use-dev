using System.Security.Cryptography;
using System.Text;

namespace Abc.Test.Setup;
public static class Funcs
{
    public static readonly Func<string?, string?> HashAnyToAscii = x => Encoding.ASCII.GetString(SHA256.HashData(Encoding.Unicode.GetBytes(x)));
}
