using System;
using System.Text;
using Agency.Exceptions;
using Agency.Models.Contracts;

namespace Agency.Models
{
    public class Ticket : ITicket
    {
        private int _id;
        private IJourney _journey;
        private double _administrativeCosts;
        public Ticket(int id, IJourney journey, double administrativeCosts)
        {
            _id = id;
            _journey = journey;
            if (administrativeCosts < 0)
            {
                throw new InvalidUserInputException($"Value of 'costs' must be a positive number. Actual value: {administrativeCosts:F2}.");
            }
            _administrativeCosts = administrativeCosts;
        }


        public double AdministrativeCosts => _administrativeCosts;

        public IJourney Journey => _journey;

        public int Id => _id;

        public double CalculatePrice()
        {
            return _journey.CalculatePrice() * AdministrativeCosts;
        }

        public override string ToString()
        {
            //Ticket ----
            //Destination: VALUE
            //Price: VALUE
            StringBuilder ticketInfo = new StringBuilder();
            ticketInfo.AppendLine("Ticket ----");
            ticketInfo.AppendLine($"Destination: {_journey.Destination}");
            ticketInfo.AppendLine($"Price: {CalculatePrice():F2}");
            return ticketInfo.ToString();
        }
    }
}
