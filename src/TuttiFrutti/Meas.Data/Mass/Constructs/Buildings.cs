namespace Meas.Data.Mass;
public partial class Constructs
{
    public static readonly Dir Buildings = new() {
        ["The Great Pyramid of Giza"] = [(5.75 * million, tonnes), (2_204.62 * million, pound)],
        ["Burj Khalifa"] = [(2.2 * million, tonnes)],
        ["One World Trade Center"] = [(500_000, tonnes)],
    };
}
