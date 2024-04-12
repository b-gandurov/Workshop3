using System;
using Agency.Models.Contracts;

namespace Agency.Models
{
    public class Journey
    {
        private const int StartLocationMinLength = 5;
        private const int StartLocationMaxLength = 25;
        private const int DestinationMinLength = 5;
        private const int DestinationMaxLength = 25;
        private const int DistanceMinValue = 5;
        private const int DistanceMaxValue = 5000;

        public Journey(int id, string from, string to, int distance, IVehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
