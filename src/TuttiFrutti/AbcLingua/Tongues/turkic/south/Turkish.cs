namespace AbcLingua.Tongues.turkic.south;
public abstract class Turkish : Family, IScript, ISupported // Latin version is modern standard
{
    public interface Latin : ILatin, ISupported;
    public interface Arabic : IArabic, ISupported;
}
