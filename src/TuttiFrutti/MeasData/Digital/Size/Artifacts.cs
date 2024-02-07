
namespace MeasData.Digital.Size;
public partial class Size
{
    Dir Books = new() {
        ["Project Gutenberg King James Bible (Old&New Testaments)"] = [(4.13, MByte), (4_332_914, bytes)],
        ["A la recherche du temps perdu, Marcel Proust"] = [(9.163_857, megabyte), (9_609_000, bytes)], // in characters
    };

    Dir Images = new() {
        ["Russell Kirsch son, 1st, digital stored photo size, 176x176px,b&w, 1957)"] = [(176 * 176, bits), (3_872, bytes), (30.25, kilobit), (3.781_25, KB)],
        ["Da Vinci, Last Supper, wiki, JPEG)"] = [(40.7, MByte), (42_764_118, bytes)],
        ["Hubble, Jupiter, original, TIF, Aug/2020"] = [(1.49, MByte), (1_572_678, bytes)],
    };

    Dir Videos = new() {
        ["YouTube max. size, 12 hr, 2024"] = [(128, GByte)],
    };

    Dir DigiWorld = new() {

        ["Global datasphere, 2024"] = [(175, zettabytes), (192_414_534_860_800, GByte)],
    };
}
