using Agency.Models.Contracts;
using Agency.Validators;
using System;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Agency.Models
{
    public class Airplane : Vehicle, IAirplane
    {
        private const int PassengerCapacityMinValue = 1;
        private const int PassengerCapacityMaxValue = 800;
        public string CapacityMessage =
            $"An airplane cannot have less than {PassengerCapacityMinValue} passengers or more than {PassengerCapacityMaxValue} passengers.";
        private const double PricePerKilometerMinValue = 0.10;
        private const double PricePerKilometerMaxValue = 2.50;
        public string PriceMessage =
            $"The price per km for bus must be between {PricePerKilometerMinValue:F2} and {PricePerKilometerMaxValue:F2}.";

        private bool _isLowCost;

        public Airplane(int id, int passengerCapacity, double pricePerKilometer, bool isLowCost)
            : base(id, passengerCapacity, pricePerKilometer)
        {

            _isLowCost = isLowCost;
            NumbericValidators.RangeValidator(PassengerCapacityMinValue, PassengerCapacityMaxValue, passengerCapacity, CapacityMessage);
            NumbericValidators.RangeValidator(PricePerKilometerMinValue, PricePerKilometerMaxValue, pricePerKilometer, PriceMessage);
        }

        public bool IsLowCost => _isLowCost;

        public override string ToString()
        {
            //Airplane ----
            //Passenger capacity: VALUE
            //Price per kilometer: VALUE
            //Is low - cost: VALUE
            StringBuilder vehicleInfo = new StringBuilder();
            vehicleInfo.AppendLine($"Airplane ----");
            vehicleInfo.Append(base.ToString());
            vehicleInfo.AppendLine($"Is low-cost: {IsLowCost.ToString()}");
            return vehicleInfo.ToString();
        }
    }
}
