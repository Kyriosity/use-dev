namespace WizCode.Xform;

public abstract class Core<TSeed, TRes>
{

    // EXTRA COLUMN for Func<TRes, TSeed>

    internal TSeed Subject { get; init; } = NotSet.Throw();

    internal TW Next<TW>() where TW : Core<TSeed, TRes>, new() {
        var next = new TW { Subject = Subject };
        // ToDo: copy core
        return next;
    }

    abstract protected TRes Result();
}
