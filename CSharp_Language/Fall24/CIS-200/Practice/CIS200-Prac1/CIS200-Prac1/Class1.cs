using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS200_Prac1
{
    public abstract class Animal
    {
        public string Species { get; set; }
        public int YearOfBirth { get; set; }
        public int CalcAge () {return DateTime.Now.Year - YearOfBirth;}
        public abstract int EstimatePopulation();
    }

    public class Bird : Animal
    {
        public float WingSpan { get; set; }
        public double MaxAltitude { get; set; }
        public double MaxRange { get; set; }

        public override int EstimatePopulation()
        {
            return (int) MaxRange * 500;
        }
    }
}
