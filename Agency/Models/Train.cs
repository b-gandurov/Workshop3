using Agency.Models.Contracts;
using Agency.Validators;
using System;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Agency.Models
{
    public class Train:Vehicle,ITrain
    {
        private const int PassengerCapacityMinValue = 30;
        private const int PassengerCapacityMaxValue = 150;
        public string CapacityMessage =
            $"A train cannot have less than {PassengerCapacityMinValue} passengers or more than {PassengerCapacityMaxValue} passengers.";
        private const double PricePerKilometerMinValue = 0.10;
        private const double PricePerKilometerMaxValue = 2.50;
        public string PricePerKmMessage =
            $"The price per km for bus must be between {PricePerKilometerMinValue:F2} and {PricePerKilometerMaxValue:F2}.";
        private const int CartsMinValue = 1;
        private const int CartsMaxValue = 15;
        public string CartsCapacity =
            $"A train cannot have less than {CartsMinValue} cart or more than {CartsMaxValue} carts.";
        private int _carts;

        public Train(int id, int passengerCapacity, double pricePerKilometer, int carts)
            :base(id,passengerCapacity,pricePerKilometer) 
        {
            NumbericValidators.RangeValidator(PassengerCapacityMinValue, PassengerCapacityMaxValue, passengerCapacity, CapacityMessage);
            NumbericValidators.RangeValidator(PricePerKilometerMinValue, PricePerKilometerMaxValue, pricePerKilometer, PricePerKmMessage);
            NumbericValidators.RangeValidator(CartsMinValue, CartsMaxValue, carts, CartsCapacity);
            _carts = carts;
        }

        public int Carts => _carts;

        public override string ToString()
        {
            //Train ----
            //Passenger capacity: VALUE
            //Price per kilometer: VALUE
            //Carts amount: VALUE
            StringBuilder vehicleInfo = new StringBuilder();
            vehicleInfo.AppendLine($"Train ----");
            vehicleInfo.Append(base.ToString());
            vehicleInfo.AppendLine($"Carts amount: {Carts}");
            return vehicleInfo.ToString();
        }
    }
}
