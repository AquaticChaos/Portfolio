using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Start
{
    public class Cushion
    {
        private string _material;
        private double _length, _width, _height;

        public Cushion(string material, double length, double width, double height)
        {
            Material = material;
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > 0 && value <= 24)
                {
                    _length = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid Length!");
                }
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0 && value <= 24)
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid Width!");
                }
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > 0 && value <= 24)
                {
                    _height = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid Height!");
                }
            }
        }



        public string Material
        {
            get
            {
                return _material;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || (value != "Foam" && value != "Stuffing"))
                {
                    throw new ArgumentOutOfRangeException("Invalid Cushion Material!");
                }
                else
                {
                    _material = value;
                }
            }
        }

        public double CalcVolume()
        {
            return Length * Width * Height;
        }

        public override string ToString()
        {
            return $"The cusion measures {Height} inches tall, {Width} inches wide, and {Length} inches long. It is made from {Material}";
        }
    }
}
