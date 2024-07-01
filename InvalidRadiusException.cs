using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleLab
{
    internal class InvalidRadiusException: Exception
    {
        public InvalidRadiusException() : base("Invalid radius. Radius must be greater than zero.")
        {
        }

        public InvalidRadiusException(double radius)
            : base($"Invalid radius: {radius}. Radius must be greater than zero.")
        {
        }
    }
}
