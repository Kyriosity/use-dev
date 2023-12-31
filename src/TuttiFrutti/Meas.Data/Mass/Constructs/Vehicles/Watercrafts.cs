using Meas.Data.Setup.Attributes;

namespace Meas.Data.Mass;
public partial class Constructs
{
    [NotForTest("not enough data for test")]
    public static readonly Dir Watercrafts = new() {
        //["Wonder of the seas, displacement"] = [(79_287, tonnes)],
        ["RMS Queen Mary 2, displacement"] = [(79_287, tonnes)],
    };
}
