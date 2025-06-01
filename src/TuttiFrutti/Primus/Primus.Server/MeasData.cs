namespace Primus.Server
{
    public class MeasData
    {
        public required int Id { get; init; }
        public string Title { get; set; } = "-n/a-";

        public required double UnitA { get; init; }

        public double UnitB => 32 + (double)(UnitA / 0.5556);
    }
}
