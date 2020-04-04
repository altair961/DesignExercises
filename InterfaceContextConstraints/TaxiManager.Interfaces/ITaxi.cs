namespace TaxiManager.Interfaces
{
    public interface ITaxi
    {
        int FareDollarsPerKilometer { get; set; }

        double CalculateFare(double coveredDistanceKilometers);
    }
}
