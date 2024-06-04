namespace AbcChrono.Sol3.Calendar;
public interface IMonths<out Res> where Res : IAnnual
{
    public Res January(byte dayNr); public Res January();
    public Res February(byte dayNr); public Res February();
    public Res March(byte dayNr); public Res March();
    public Res April(byte dayNr); public Res April();
    public Res May(byte dayNr); public Res May();
    public Res June(byte dayNr); public Res June();
    public Res July(byte dayNr); public Res July();
    public Res August(byte dayNr); public Res August();
    public Res September(byte dayNr); public Res September();
    public Res October(byte dayNr); public Res October();
    public Res November(byte dayNr); public Res November();
    public Res December(byte dayNr); public Res December();

}
