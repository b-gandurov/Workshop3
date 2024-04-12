using System;

namespace Agency.Models
{
    public class Airplane
    {
        private const int PassengerCapacityMinValue = 1;
        private const int PassengerCapacityMaxValue = 800;
        private const double PricePerKilometerMinValue = 0.10;
        private const double PricePerKilometerMaxValue = 2.50;
        
        public Airplane(int id, int passengerCapacity, double pricePerKilometer, bool isLowCost)
        {
            throw new NotImplementedException();
        }
    }
}
