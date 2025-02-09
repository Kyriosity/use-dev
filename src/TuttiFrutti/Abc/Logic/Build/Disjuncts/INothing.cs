namespace Abc.Logic.Build.Disjuncts;
public interface INothing<Rtrn> : IBlank<Rtrn>, IDisjunction where Rtrn : ITruthValuing
{
    bool NullOrEmpty { get; }
    Rtrn NullEmptyOr { get; }
}