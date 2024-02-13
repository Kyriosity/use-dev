using Funcware.Numeric.SameType.InUnit.FuncStore;

namespace MeasFuncware.Convert.Temperature;

public class FuncStore<U> : CustomProvider<U> where U : Enum
{
    protected override IDictionary<(U from, U to), Func<N, N>> FuncsBag<N>() {
        return base.FuncsBag<N>();
    }
}
