using Meas.Data.Setup.Attributes;

namespace Meas.Data.Mass;

public partial class Astro
{
    [Precision(.000_000_1)]
    Dir SolarSystem = new() {
        ["Sun"] = [(1, astronomical_unit), (1_988_920 * yotta, kilograms), (332_946.0487, Earth_mass)], // 332946.0487±0.0007
        ["Earth"] = [(1, Earth_mass), (5.9722 * ronna, kg), (5.9722 * yotta, kg)],
        ["Moon"] = [(0.012_300_037_1, Earth_mass),],

        ["Mercury"] = [(0.055_3, Earth_mass),],
        ["Venus"] = [(0.815, Earth_mass),],

        ["Mars"] = [(0.107, Earth_mass),],
        ["Phobos (Mars I)"] = [(10.659 * peta, kilogram),],
        ["Deimos (Mars II)"] = [(1.4762 * peta, kilogram)],

        ["Jupiter"] = [(317.8, Earth_mass),],
        ["Io (Jupiter I)"] = [(0.015, Earth_mass), (89_319_380 * peta, kilogram)], // (8.931938±0.000018) * 10x22 kg
        ["Europa (Jupiter II)"] = [(0.008, Earth_mass), (47_998_440 * peta, kilogram)], // (4.799844±0.000013) * 10x22 kg
        ["Ganymede (Jupiter III)"] = [(0.025, Earth_mass), (148_190_000 * peta, kilogram)], // 1.4819 * 10x23 kg 
        ["Callisto (Jupiter IV)"] = [(0.018, Earth_mass), (107_593_800 * peta, kilogram)], // (1.075938±0.000137) * 10x23 kg

        ["Saturn"] = [(95.2, Earth_mass),],
        ["Titan (moon)"] = [(0.0225, Earth_mass), (134_520_000 * peta, kilogram)], // (1.3452±0.0002) * 10x23 kg

        ["Uranus"] = [(14.5, Earth_mass),],
        ["Ariel (Uranus I)"] = [(1_251_000 * peta, kilogram),], // (1.251±0.021) * 10x21 kg
        ["Umbriel (Uranus II)"] = [(11_694 * peta, kilogram),],
        ["Oberon (Uranus IV)"] = [(3_076_000 * peta, kilogram),], // (3.076±0.087) * 10x21 kg
        ["Titania (Uranus III)"] = [(3_400_000 * peta, kilogram),], // (3.400±0.061) * 10x21 kg

        ["Neptune"] = [(17.1, Earth_mass),],
        ["Triton (moon)"] = [(0.003_59, Earth_mass), (21_390_000 * peta, kilogram)], // (2.1390±0.0028) * 10x22 kg
        ["Proteus (moon)"] = [(0.000_007_367_2, Earth_mass), (44_000 * peta, kilogram)], // 
        ["Nereid (moon)"] = [(0.000_005_2, Earth_mass), (31_000 * peta, kilogram)], //

        ["Pluto"] = [(0.002_5, Earth_mass),],
        ["Charon (Pluto)"] = [(1_586_000 * peta, kilogram),],

        ["Haumea"] = [(0.000_66, Earth_mass), (4_010_000 * peta, kilogram),], //  dwarf beyond Neptune
        ["Eris"] = [(0.002_7, Earth_mass),], // most massive and second-largest (known) dwarf planet 
        ["Makemake"] = [(0.00053, Earth_mass),], // second-largest of what are known as the classical population of Kuiper belt objects
    };
}
