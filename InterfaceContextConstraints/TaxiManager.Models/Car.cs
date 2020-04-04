using TaxiManager.Interfaces;

namespace TaxiManager.Models
{
    public class Car : ITaxi, IWashable
    {
        public int FareDollarsPerKilometer { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public double CalculateFare(double coveredDistanceKilometers)
        {
            throw new System.NotImplementedException();
        }
    }
}
