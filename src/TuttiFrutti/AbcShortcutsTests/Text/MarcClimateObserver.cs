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
    public void OnThrust(object? sender, Thrust args) {
        // Trajectory.Expectation.Adjust();
    }
}

class Thrust : EventArgs
{
    public double Magnitude;
    public int Direction;
    public int Duration;
}

//namespace LokheedMartin.Apparate;

class Spacecraft
{
    public event EventHandler<Thrust> AngularMomentumDesaturation = (_, _) => { };

    public void DeSpun() {
        AngularMomentumDesaturation?.Invoke(this, new Thrust { Direction = 1, Magnitude = 1 });
    }

    public void Launch() { }
}