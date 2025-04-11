using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Start
{
    public class Seat : Furniture
    {
        private int _seats, _legs;


        public Seat(decimal price, string category, double weight, int seats, int legs) : base(price, category, weight)
        {
            Seats = seats;
            Legs = legs;
        }

        public int Seats
        {
            get
            {
                return _seats;
            }
            set
            {
                if (value > 0 && value <= 24)
                {
                    _seats = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid Number of Seats!");
                }
            }
        }

        public int Legs
        {
            get
            {
                return _legs;
            }
            set
            {
                if (value > 0 && value <= 10)
                {
                    _legs = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid Number of Legs!");
                }
            }
        }

        public double WeightPerLeg()
        {
            return Weight / Legs;
        }

        public override string ToString()
        {
            return $"The seat has {Legs} legs and can sit {Seats}. It weighs {Weight:g2} pounds and cost {Price:c}. It is categorized as a {Category}";
        }
    }
}
