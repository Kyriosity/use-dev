namespace AbcLingua.Tongues;

public interface IDefault : ITongue, IScript;

public abstract class Current : IDefault, IScript, ISupported
{
    public abstract class UI : IDefault, IScript, ISupported;
}