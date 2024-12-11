namespace MeasData.Calibration.Metric;
public class Mass : MeasData.Mass.Synonyms
{
    // ToDesign: re-design (add diff types ?and? move to masses)
    public static readonly object[][] Calibres = [
        [1.5, gram, "=", 0.0015, kilogram],
        [-3.37, gram, "=", -3_370.00, milligram],
        [7.47, kilogram, "=", 0.00747, tonne],

        [1_465.43, kilogram, "=", 14.654_3, "centner"], // ToDo: prove what centner equals?
    ];
}
