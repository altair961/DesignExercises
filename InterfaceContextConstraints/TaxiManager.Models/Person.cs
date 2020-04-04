using System;
using TaxiManager.Interfaces;

namespace TaxiManager.Models
{
    public class Person : ITaxiClient
    {
        public void AssignContractor(ITaxi taxi)
        {
            throw new NotImplementedException();
        }
    }
}
