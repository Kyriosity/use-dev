namespace MeasData.Length.Earth.Elevations;

public partial class Dirs
{
    Dir Mounts = new() {
        [Everest] = [(8_848.86, meter), (29_031.692_91, feet), (8.848_86, km), (5.498426688, mile)],
        [K2] = [(8_609.02, meter), (28_244.81627, feet)],
        [Aconcagua] = [(6_960.8, m), (22_837.270_3, ft)],
        ["Kangchenjunga"] =
            [(8586, m), (28_169, ft)],
        ["Mont Blanc"] = [(4_805.59, metre)],
        ["Zugspitze"] =
            [(2_962.06, m), (9_718.044_6, ft)],
        [Denali] =
           [(6_190.5, m), (20310.04, ft)],
        ["Yu Shan"] = [(3_952.43, m), (12_967.290, ft)],
        [Fuji] = [(3_776.24, m)],
        ["Mount Kosciuszko"] = [(2_228, m)],
        ["Teide"] = [(3_715, m)],
        ["Vinson"] = [(4_892, m)],
        ["Puncak Jaya"] = [(4_884, m)], // highest island mountain
        ["Chimborazo"] = [(6_263.47, m)], // furthest pt from Earth center
    };

    Dir Depressions = new() {
        ["Dead Sea"] = [(-413, m), (-1_354.99, foot)],
        ["Lac 'Assal"] = [(-155, m), (-508.53, foot)],
        ["San Julian's Great Depression"] = [(-105, m), (-344.488, foot)],
        ["Death Valley"] = [(-86, m), (-282.152, foot)],
        ["Neuendorf-Sachsenbande"] = [(-3.54, m), (-11.614_17, foot)],
    };
}