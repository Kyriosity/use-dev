namespace AbcModels.Library.Ids;
public interface ISBN : Abc.Marks.IUnique // : InternationalMarketingNumber
{
    string CheckDigit { get; }
    // group 
}

public interface ISBN10Digit : ISBN
{
}

public interface ISBN13Digit : ISBN // since 01.01.2007, not compatible with 13 digit
{

    string CheckDigit { get; }
}