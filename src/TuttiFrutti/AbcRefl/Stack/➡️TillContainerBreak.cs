namespace AbcRefl.Stack;
public partial class Caller
{
    public static StackDetails? ReportToContainerFallback() {

        StackDetails? frame = null;
        var nulled = false;

        for (byte i = 1; !nulled; i++) {
            var next = Details(i);
            if (next.container.name is null)
                nulled = true;
            else
                frame = next;
        }

        return frame;
    }

    public static string Digest {
        get {
            var query = ReportToContainerFallback();
            if (query is null)
                return "<<*[NULL]*>> ";

            var report = query.Value;
            return $"{report.container.name}.{report.member.name}: ";
        }
    }
}
