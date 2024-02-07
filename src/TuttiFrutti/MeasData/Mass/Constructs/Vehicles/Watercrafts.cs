using MeasData.Setup.Metadata;

namespace MeasData.Mass.Constructs;
public partial class Constructs
{
    [NotForTest("not enough data for test")]
    Dir Watercrafts = new() {
        //["Wonder of the seas, displacement"] = [(79_287, tonnes)],
        ["RMS Queen Mary 2, displacement"] = [(79_287, tonnes)],
    };
}
