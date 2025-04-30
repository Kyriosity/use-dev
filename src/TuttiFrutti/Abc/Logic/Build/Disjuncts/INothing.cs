namespace Abc.Logic.Build.Disjuncts;
public interface INothing<TRet> : IBlank<TRet>
{
    bool NullOrEmpty { get; }
    TRet NullEmptyOr { get; }
}