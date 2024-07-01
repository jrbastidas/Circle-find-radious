using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleLab
{
    public class Circle
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value > 0)
                {
                    _radius = value;
                }
                else
                {
                    throw new InvalidRadiusException(value);
                }
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override string ToString()
        {
            return $"Circle with radius: {Radius}";
        }
    }

}
