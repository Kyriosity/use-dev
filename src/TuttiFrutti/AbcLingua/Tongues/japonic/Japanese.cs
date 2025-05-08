namespace AbcLingua.Tongues.japonic;
public abstract class Japanese : Family, ISupported, ISyllabary, ILatin, IChineseFamily // uses mixes of scripts
{
    public interface Kanji : IChineseFamily, ISupported; // adapted from the Chinese script 
    public interface Hiragana : ISyllabary, ISupported;
    public interface Katakana : IScript, ISyllabary, ISupported;
    public interface Rōmaji : ILatin, ISupported; // romanized version
}
