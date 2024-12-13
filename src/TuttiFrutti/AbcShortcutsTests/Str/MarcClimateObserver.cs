namespace NASA.Missions;

class MarsClimateObserver
{
    public void Main() {
        var navTeam = new Navigaton();
        var spacecraft = new Spacecraft();
        spacecraft.AngularMomentumDesaturation += navTeam.OnThrust;
        // other boilerplate

        try {
            spacecraft.Launch();
        } catch { }
    }
}

class Navigaton
{
    public void OnThrust(object? sender, ThrustArgs args) {
        // Trajectory.Expectation.Adjust();
    }
}

public class ThrustArgs : EventArgs
{
    public double Magnitude;
    public int Direction;
}

//namespace LokheedMartin.Apparate;

class Spacecraft
{

    public event EventHandler<ThrustArgs> AngularMomentumDesaturation = (_, _) => { };

    public void DeSpun() {
        AngularMomentumDesaturation?.Invoke(this, new ThrustArgs { Direction = 1, Magnitude = 1 });
    }

    public void Launch() { }
}