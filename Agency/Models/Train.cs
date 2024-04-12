using System;

namespace Agency.Models
{
    public class Train
    {
        private const int PassengerCapacityMinValue = 30;
        private const int PassengerCapacityMaxValue = 150;
        private const double PricePerKilometerMinValue = 0.10;
        private const double PricePerKilometerMaxValue = 2.50;
        private const int CartsMinValue = 1;
        private const int CartsMaxValue = 15;

        public Train(int id, int passengerCapacity, double pricePerKilometer, int carts)
        {
            throw new NotImplementedException();
        }
    }
}
