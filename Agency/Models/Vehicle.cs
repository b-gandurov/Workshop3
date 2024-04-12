using Agency.Exceptions;
using Agency.Models.Contracts;
using System.Text;

namespace Agency.Models
{
    public abstract class Vehicle: IVehicle
    {
        private int _id;
        private int _passengerCapacity;
        private protected string CapacityMessage = "A vehicle with less than 1 passengers or more than 800 passengers cannot exist!";
        private double _pricePerKilometer;
        private protected string PricePerKmMessage = "A vehicle with a price per kilometer lower than $0.10 or higher than $2.50 cannot exist!";


        public Vehicle(int id, int passengerCapacity,double pricePerKilometer)
        {

            _id = id;
            _passengerCapacity = passengerCapacity;
            _pricePerKilometer = pricePerKilometer;

            PreValidate(passengerCapacity, pricePerKilometer);
        }

        public int PassengerCapacity => _passengerCapacity;

        public double PricePerKilometer => _pricePerKilometer;

        public int Id => _id;

        private void PreValidate(int passengerCapacity, double pricePerKilometer)
        {
            if (passengerCapacity < 1 || passengerCapacity > 800)
            {
                throw new InvalidUserInputException("A vehicle with less than 1 passengers or more than 800 passengers cannot exist!");
            }

            if (pricePerKilometer < 0.10 || pricePerKilometer > 2.50)
            {
                throw new InvalidUserInputException("A vehicle with a price per kilometer lower than $0.10 or higher than $2.50 cannot exist!");
            }
        }

        public override string ToString()
        {
            //Passenger capacity: VALUE
            //Price per kilometer: VALUE
            StringBuilder vehicleInfo = new StringBuilder();
            vehicleInfo.AppendLine($"Passenger capacity: {PassengerCapacity}");
            vehicleInfo.AppendLine($"Price per kilometer: {PricePerKilometer:F2}");
            return vehicleInfo.ToString();
        }
    }
}
