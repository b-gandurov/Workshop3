using Agency.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Validators
{
    public class NumbericValidators
    {
        public static void RangeValidator<T>(T minValue, T maxValue, T value, string message) where T : IComparable
        {
            if (value.CompareTo(maxValue) > 0 || value.CompareTo(minValue) < 0)
            {
                throw new InvalidUserInputException(message);
            }
        }

    }
}
