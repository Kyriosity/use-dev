using MeasData.Setup.Metadata;

namespace MeasData.Mass.Astro;
public partial class Astro
{
    [NotForTest("incomplete")]
    Dir Galaxy = new() {
        //["1I/2017 U1"] = [(, Earth_mass),] // aka ʻOumuamua, 1st interstellar object detected passing through the Solar System

        ["Sirius A"] = [(2.063, solar_mass),],
        ["Sirius B"] = [(1.018, solar_mass),],

        ["Alpha Centauri A"] = [(0.909_2, solar_mass),],
        ["Proxima Centauri b"] = [(1.07, Earth_mass),],

        ["Vega"] = [(2.135, solar_mass),],
        ["Aldebaran"] = [(1.16, solar_mass),],
        ["Polaris"] = [(5.4, solar_mass),],

        ["R136a1"] = [(230, solar_mass),], // the heaviest star in the cosmos as far as humans know.

        ["Gliese 667 Cc"] = [(3.8, Earth_mass),], // exoplanet orbiting within the habitable zone of the red dwarf star Gliese 667 C

        ["101955 Bennu"] = [(73_290 * million, kg)], // (7.329±0.009) * 10x10 kg
    };
}