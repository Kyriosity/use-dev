using AbcExt.Errors.Argument;
using AbcExt.Stubs.Args;
using System.Runtime.CompilerServices;

namespace ClayTests.Errors;
public class MiscDemos
{
    [Test]
    public void ShowOverwriteOfRuntimeSet() {

        var user = Login("user123", "123");
        Assert.That(user, Is.EqualTo(nameof(ShowOverwriteOfRuntimeSet)));

        user = Login("user123", "123", "cool hacker");
        Assert.That(user, Is.EqualTo("cool hacker"));

    }

    [Test]
    public void HitLimitSwitch() {

        DuplicatedArguments.ThrowIfAny("A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K");

        Assert.Throws<InvalidOperationException>(() =>
        DuplicatedArguments.ThrowIfAny("A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K",
          new YOU_REACHED_ARGs_LIMIT___METAs_NEXT()));

        DuplicatedArguments.ThrowIfAny("A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", default, "BAD TRICK: with default can overwrite");
    }


    private static string Login(string name, string password, [CallerMemberName] string user = "<must be set by caller>") => user;
}
