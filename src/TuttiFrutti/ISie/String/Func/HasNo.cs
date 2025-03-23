

namespace ISie.String.Func;
class HasNo
{
    internal static readonly Func<string, bool> Controls = subj => subj is "" ? Empty.Throw() :
        !Has.ControlChars(subj);
}
