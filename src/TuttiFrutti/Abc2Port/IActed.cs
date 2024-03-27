namespace Abc;
public interface IActed<T>
{
    public void Do(params T[] items);
}
