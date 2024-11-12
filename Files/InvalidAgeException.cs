using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingH1day6.Files;

internal class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message)
    {
    }

}
