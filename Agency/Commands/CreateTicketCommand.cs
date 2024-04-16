using Agency.Commands.Abstracts;
using Agency.Core.Contracts;
using Agency.Exceptions;
using Agency.Models.Contracts;
using System;
using System.Collections.Generic;

namespace Agency.Commands
{
    public class CreateTicketCommand : BaseCommand
    {
        public const int ExpectedNumberOfArguments = 2;

        public CreateTicketCommand(IList<string> commandParameters, IRepository repository)
            : base(commandParameters, repository)
        {
        }
        
        public override string Execute()
        {
            ValidateParameterCount(ExpectedNumberOfArguments);
            //if (this.CommandParameters.Count < ExpectedNumberOfArguments)
            //{
            //    throw new InvalidUserInputException($"Invalid number of arguments. Expected: {ExpectedNumberOfArguments}, Received: {this.CommandParameters.Count}");
            //}

            // Parameters:
            //  [0] - journey ID
            //  [1] - administrativeCosts
            double administrativeCosts = this.ParseDoubleParameter(CommandParameters[1], "administrativeCosts");
            int journeyId = this.ParseIntParameter(CommandParameters[0], "journeyId");
            IJourney journey = base.Repository.FindJourneyById(journeyId);
            

            var ticket = base.Repository.CreateTicket(journey, administrativeCosts);
            return $"Ticket with ID {ticket.Id} was created.";
        }
    }
}
