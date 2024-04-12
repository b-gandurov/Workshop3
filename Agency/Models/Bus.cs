using Agency.Models.Contracts;
using System;

namespace Agency.Models
{
    public class Bus : Vehicle, IBus,IVehicle
    {
        private const int PassengerCapacityMinValue = 10;
        private const int PassengerCapacityMaxValue = 50;
        private const double PricePerKilometerMinValue = 0.10;
        private const double PricePerKilometerMaxValue = 2.50;
        public bool _hasFreeTV;

        public Bus(int id, int passengerCapacity, double pricePerKilometer, bool hasFreeTv)
            : base(id, passengerCapacity, pricePerKilometer)
        {
            _hasFreeTV=hasFreeTv;
        }


        public bool HasFreeTv => _hasFreeTV;
    }
}
