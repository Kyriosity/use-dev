using AbcChrono.Timescales;


namespace AbcChrono.Convert;
class Full<NRes> : IYears<NRes> where NRes : INumber<NRes>
{
    public required On Target {
        get => field;
        init {
            field = On.Undefined == value ? Argument.Throw($"{nameof(On)} can't be set {value}") : value;
        }
    }

    public NRes From<N>(On source, N val, In unit) where N : INumber<N> {

        NotImplemented.ToDo("Ago support");

        if (On.Undefined == source)
            Argument.Throw(source);
        var sourceYear = In.Undefined == unit ? Argument.Throw(unit) :
            val * N.CreateChecked((uint)unit); // NOTE: this is a simplification to be replaced with U-Val

        if (source == Target)
            return sourceYear; // REVERSE !

        return NotImplemented.ToDo(NRes.One, "not supported");
    }
}