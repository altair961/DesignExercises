using TaxiManager.Models;

namespace TaxiManager.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var availableclient = new Person();
            var car = new Car();
            var washer = new Station();

            washer.Wash(car);

            availableclient.AssignContractor(car);
        }
    }
}
