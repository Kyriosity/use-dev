namespace ISie.String.BlankProof;
internal class NullEmptyCheckMenu : EmptyCheckMenu
{
    protected override bool Eval() =>
        Seed is null or "";
}
