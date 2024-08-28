namespace AbcModels.Samples;
public class Book
{

}

public partial class Dir
{
    public IEnumerable<Book> Books => new List<Book> {
        new Book(),
        new Book(),
        new Book(),
    };
}

public partial class Dir
{
    public IEnumerable<Book> Books2 => new List<Book> {
        new Book(),
        new Book(),
        new Book(),
    };


}
