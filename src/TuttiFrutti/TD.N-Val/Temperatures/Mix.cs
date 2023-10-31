using TestData.N_Val.Temperatures.Vals;

namespace TestData.N_Val.Temperatures;
public static class Mix
{
    public readonly static object[] NumericTypes = {
            new object[] { "+ tiny", Positive.Tiny},
            new object[] { "- whole num", Negative.Integer },
            new object[] { "- float-pt num", Negative.Precise },

            new object[] { "0 K", Zero.Kelvin},
            new object[] { "0 C", Zero.Celsius},
            new object[] { "0 F", Zero.Fahrenheit},

            new object[] { "Water boiling", Water.Boiling },
            new object[] { "WaterTriplePoint",  Water.TriplePoint },

            new object[] { "Earth, recorded min", Earth.RecordedMin },
            new object[] { "Earth, recorded max", Earth.RecordedMax },
            new object[] { "Earth surface average", Earth.AvgSurface },
            new object[] { "Etna magma", Earth.EtnaMagma },
            new object[] { "Daily average water, max", Earth.AvgOceanSurface_31Jul2023 },

            new object[] { "Absolute zero", Phys.AbsZero },
            new object[] { "Potassium atoms < abs. 0", Phys.AtomicGas },
            new object[] { "Quark gluon plasma, CERN, year 2012", Phys.QuarkGluonPlasma_CERN2012 },

            new object[] { "Quicksilver melting", Melting.Quicksilver },
            new object[] { "Silver melting", Melting.Silver },
            new object[] { "Gold melting", Melting.Gold },

            new object[] { "Outer space", Cosmo.Space },
            new object[] { "Hottest in Universe", Cosmo.UniverseHottest },
            new object[] { "Earth core", Cosmo.EarthCore },
            new object[] { "Sun core", Cosmo.SunCore },
            new object[] { "Sun surface", Cosmo.SunSurface },
        };

    public readonly static object[] HugeValues = {
            new object[] { "+ huge whole", Positive.HugeWhole },
            new object[] { "- huge whole", Negative.HugeWhole },
    };

    public readonly static object[] UltraValues = {
        new object[] { "+ longest", Positive.Longest },
        new object[] { "- longest", Negative.Longest },
    };

    public readonly static object[] ControlPoints = {
        new object[] { "F=C intersection", Intersection.FahrnheitWithCelsius },
        new object[] { "F=K intersection", Intersection.FahrnheitWithKelvin },
    };
}
