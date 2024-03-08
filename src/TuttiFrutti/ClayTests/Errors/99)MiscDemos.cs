using AbcExt.Stubs.Args;
using System.Runtime.CompilerServices;

namespace ClayTests.Errors;
public class MiscDemos
{
    [Test]
    public void ShowOverwriteOfRuntimeSet() {
        Assert.That(Login("user123", "***"), Is.EqualTo(nameof(ShowOverwriteOfRuntimeSet)));
        Assert.That(Login("user123", "***", "cool hacker"), Is.EqualTo("cool hacker"));
    }

    [Test]
    public void HitLimitSwitch() {
        DuplicatedArguments.ThrowIfAny("A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K");

        Assert.Throws<InvalidOperationException>(() =>
        DuplicatedArguments.ThrowIfAny("A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K",
          new YOU_REACHED_ARGs_LIMIT___METAs_NEXT()));

        DuplicatedArguments.ThrowIfAny("A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K",
            default, "BAD TRICK: with default can overwrite");
    }

    private static string Login(string name, string password, [CallerMemberName] string user = "<will be set by caller>") => user;
}
