namespace AbcLingua.Tongues.indo_euro.italic;
public abstract class Latin : Family, ILatin, ISupported
{
    public interface Classical : ILatin, ISupported; // Latin w/out J, U and W
}
