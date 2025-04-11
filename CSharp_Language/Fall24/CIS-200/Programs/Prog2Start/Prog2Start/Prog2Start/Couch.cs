using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Start
{
    public class Couch: Seat
    {
        private string _material;
        private Cushion _cushion;

        public Couch(decimal price, string category, double weight, int seats, int legs, string material, Cushion cushion) : base(price, category,weight,seats, legs)
        {
            Material = material;
            Cushion = cushion;
        }

        public string Material
        {
            get
            {
                return _material;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || (value != "Leather" && value != "Textile"))
                {
                    throw new ArgumentOutOfRangeException("Invalid Material Entered!");
                }
                else
                {
                    _material = value;
                }
            }
        }

        public Cushion Cushion
        {
            get { return _cushion; }
            set
            {
                if (value != null)
                {
                    _cushion = value;
                }
                else
                {
                    throw new NullReferenceException("No Cushion Object Found!");
                }
            }
        }

    }
}
