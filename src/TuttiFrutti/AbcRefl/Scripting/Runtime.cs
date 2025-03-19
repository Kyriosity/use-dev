using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace AbcRefl.Scripting;

internal class Runtime
{
    internal static async Task<object> Compile(string script, object? globals = null, string[]? references = null, string? imports = null) {
        var options = references is null ? null :
            ScriptOptions.Default.WithReferences(references);

        if (imports is not null)
            options = options is null ? ScriptOptions.Default.WithImports(imports) : options.WithImports(imports);

        return await CSharpScript.EvaluateAsync(script, options: options, globals: globals);
    }

    internal class Dummy
    {
        internal static object Compile(Type implementType) {
            var task = Runtime.Compile($"public class Dummy : {implementType.FullName} {{ int Id = -123;}}; var dummy = new Dummy(); return dummy;",
                string.Empty,
                [nameof(System), implementType.Assembly.ToString()],
                implementType.Namespace

            // ToDesign: test if reference in types of implemented type required
            );

            return task.Result;
        }
    }
}
