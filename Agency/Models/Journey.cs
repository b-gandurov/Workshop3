using System;
using System.Text;
using Agency.Models.Contracts;
using Agency.Validators;

namespace Agency.Models
{
    public class Journey:IJourney
    {
        private const int StartLocationMinLength = 5;
        private const int StartLocationMaxLength = 25;
        private string LocationErrorMessage =
            $"The length of StartLocation must be between {StartLocationMinLength} and {StartLocationMaxLength} symbols.";
        private const int DestinationMinLength = 5;
        private const int DestinationMaxLength = 25;
        private string DestinationErrorMessage =
            $"The length of Destination must be between {DestinationMinLength} and {DestinationMaxLength} symbols.";
        private const int DistanceMinValue = 5;
        private const int DistanceMaxValue = 5000;
        private string DistanceErrorMessage =
            $"The Distance cannot be less than {DistanceMinValue} or more than {DistanceMaxValue} kilometers.";

        private int _id;
        private string _start;
        private string _to;
        private int _distance;
        private IVehicle _vehicle;

        public Journey(int id, string from, string to, int distance, IVehicle vehicle)
        {
            _id = id;
            NumbericValidators.RangeValidator(StartLocationMinLength, StartLocationMaxLength, from.Length, LocationErrorMessage);
            _start = from;
            NumbericValidators.RangeValidator(DestinationMinLength, DestinationMaxLength, to.Length, DestinationErrorMessage);
            _to = to;
            NumbericValidators.RangeValidator(DistanceMinValue, DistanceMaxValue, distance, DistanceErrorMessage);
            _distance = distance;
            _vehicle = vehicle;
        }

        public string StartLocation => _start;

        public string Destination => _to;

        public int Distance => _distance;

        public IVehicle Vehicle => _vehicle;

        public int Id => _id;

        public double CalculatePrice()
        {
            return Distance * Vehicle.PricePerKilometer;

        }

        public override string ToString()
        {
            //Journey ----
            //Start location: VALUE
            //Destination: VALUE
            //Distance: VALUE
            //Travel costs: VALUE
            StringBuilder ticketInfo = new StringBuilder();
            ticketInfo.AppendLine("Journey ----");
            ticketInfo.AppendLine($"Start Location: {StartLocation}");
            ticketInfo.AppendLine($"Destination: {Destination}");
            ticketInfo.AppendLine($"Distance: {Distance}");
            ticketInfo.AppendLine($"Travel costs: {CalculatePrice():F2}");
            return ticketInfo.ToString();
        }
    }
}
