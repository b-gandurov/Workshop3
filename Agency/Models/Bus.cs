using Agency.Models.Contracts;
using Agency.Validators;
using System;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Agency.Models
{
    public class Bus : Vehicle, IBus
    {
        private const int PassengerCapacityMinValue = 10;
        private const int PassengerCapacityMaxValue = 50;
        private string CapacityMessage =
            $"A bus cannot have less than {PassengerCapacityMinValue} passengers or more than {PassengerCapacityMaxValue} passengers.";
        private const double PricePerKilometerMinValue = 0.10;
        private const double PricePerKilometerMaxValue = 2.50;
        private string PricePerKmMessage =
            $"The price per km for bus must be between {PricePerKilometerMinValue:F2} and {PricePerKilometerMaxValue:F2}.";

        public bool _hasFreeTV;

        public Bus(int id, int passengerCapacity, double pricePerKilometer, bool hasFreeTv)
            : base(id, passengerCapacity, pricePerKilometer)
        {

            _hasFreeTV = hasFreeTv;
            NumbericValidators.RangeValidator(PassengerCapacityMinValue, PassengerCapacityMaxValue, passengerCapacity, CapacityMessage);
            NumbericValidators.RangeValidator(PricePerKilometerMinValue, PricePerKilometerMaxValue, pricePerKilometer, PricePerKmMessage);
        }


        public bool HasFreeTv => _hasFreeTV;

        public override string ToString()
        {
            //Bus ----
            //Passenger capacity: VALUE
            //Price per kilometer: VALUE
            //Has free TV: VALUE
            StringBuilder vehicleInfo = new StringBuilder();
            vehicleInfo.AppendLine($"Bus ----");
            vehicleInfo.Append(base.ToString());
            vehicleInfo.AppendLine($"Has free TV: {HasFreeTv.ToString()}");
            return vehicleInfo.ToString();
        }
    }
}
