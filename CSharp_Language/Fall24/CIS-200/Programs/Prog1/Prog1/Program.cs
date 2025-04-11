using System.Diagnostics;
using System;

//Student ID: 5262256
//Program: 1
//Due date: 9/23/24
//Course Section:CIS-200-75-4248

namespace Prog1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Current issues:
            //  Cushion's dimensions (and volume) print as all zeroes.


            //Create objects
            Cushion cushion1 = new Cushion("Foam", 5.0, 1.5, 5.0);
            Couch couch1 = new Couch(400.00m, "Theater Couch", 300, 4, 6, "Leather", cushion1);
            DeskChair chair1 = new DeskChair(150.00m, "Gaming Chair", 15, 1, 3, true);

            //Create list of furnitures
            List<Furniture> furnList = new List<Furniture> { couch1, chair1 };


            //Print cushion, furniture list
            Console.WriteLine(cushion1.ToString() + "\n----------------------------------------\n");
            foreach (var furn in furnList)
            {Console.WriteLine(furn.ToString() + "\n----------------------------------------\n");}

        }
    }

    public abstract class Furniture
    {
        //Backing fields
        private decimal pri;
        private string categ;
        private double wght;

        //Furtniture class constructor
        public Furniture (decimal price, string category, double weight)
        {
            Price = price;
            Category = category;
            Weight = weight;
        }

        //Get-set properties
        public decimal Price
        {
            get { return this.pri; }
            set
            {
                if(value < 0) //If value is less than zero, throw an exception
                {throw new ArgumentOutOfRangeException("The furniture's price is invalid. Please set it greater than zero.");}
                else {this.pri = value;} //Otherwise, set the value
            }
        }

        public string Category
        {
            get { return this.categ; }
            set
            {
                if (String.IsNullOrWhiteSpace(value)) //If value is null or whitespace, throw an exception
                { throw new ArgumentOutOfRangeException("The furniture's category is invalid. Please enter a value."); }
                else { this.categ = value; } //Otherwise, set the value
            }
        }

        public double Weight
        {
            get { return this.wght; }
            set
            {
                if (value < 0 | value > 1000) //If value is less than 0 or greater than 1000, throw an exception
                { throw new ArgumentOutOfRangeException("The furniture's weight is invalid. Please set it between zero and 1,000."); }
                else { this.wght = value; } //Otherwise, set the value
            }
        }
    }

    public abstract class Seat : Furniture
    {
        //Backing fields
        private int sts, lg;
        public Seat (decimal price, string category, double weight, int seats, int legs) : base(price, category, weight)
        {
            Seats = seats;
            Legs = legs;
        }

        //Seats class constructor
        public int Seats
        {
            get { return this.sts; }
            set
            {
                if (value < 0 | value > 24) //If value is less than 0 or greater than 24, throw an exception
                { throw new ArgumentOutOfRangeException("The furniture's seat count is invalid. Please set it between zero and 24."); }
                else { this.sts = value; } //Otherwise, set the value
            }
        }

        //Get-set properties
        public int Legs
        {
            get { return this.lg; }
            set
            {
                if (value < 0 | value > 10) //If value is less than 0 or greater than 10, throw an exception
                { throw new ArgumentOutOfRangeException("The furniture's leg count is invalid. Please set it between zero and 10."); }
                else { this.lg = value; } //Otherwise, set the value
            }
        }

        //Override ToString to print statistics
        public override string ToString()
        {
            string ToStringValue = $"Category: {Category}" +
                $"\nWeight: {Weight} lb." +
                $"\nNumber of Seats: {Seats}" +
                $"\nNumber of Legs: {Legs}" +
                $"\nPrice: ${Price}";

            return ToStringValue; //Return the specified string above
        }

        //Custom function to calculate weight per leg
        public double WeightPerLeg()
        {
            return Weight / Legs; //Return dividend of weight and number of legs
        }
    }

    public class Couch : Seat
    {
        //Backing fields
        private string mat;
        private Cushion cush;

        //Couch class constructor
        public Couch(decimal price, string category, double weight, int seats, int legs, string material, Cushion cushion) 
            : base(price, category, weight, seats, legs)
        {
            Material = material;
            Cushion = cushion;
        }

        //Get-set properties
        public string Material
        {
            get { return this.mat; }
            set
            {
                if (String.IsNullOrWhiteSpace(value)) //If value is null or white space, throw an exception
                { throw new ArgumentOutOfRangeException("The furniture's material is invalid. Please enter a value."); }
                else { this.mat = value; } //Otherwise set the value
            }
        }

        public Cushion Cushion
        {
            get { return this.cush; }
            set
            {
                if (value == null) //If value is empty or invalid, throw an exception
                { throw new ArgumentOutOfRangeException("The furniture's cushion is invalid. Please enter a value."); }
                else { this.cush = value; } //Otherwise set the value
            }
        }

        //Override ToString to print statistics
        public override string ToString()
        {
            string ToStringValue = $"Category: {Category}" +
                $"\nWeight: {Weight} lb." +
                $"\nNumber of Seats: {Seats}" +
                $"\nNumber of Legs: {Legs}" +
                $"\nMaterial type: {Material}" +
                $"\nPrice: ${Price}" +
                $"\n\nCushion Material: {Cushion.Material}" +
                $"\nCushion Dimensions: {Cushion.Length} x {Cushion.Width} x {Cushion.Height} inches" +
                $"\nCushion Volume: {Cushion.CalcVolume()} inches cubed";

            return ToStringValue; //Return the specified string above
        }
    }

    public class DeskChair : Seat
    {
        //DeskChair class constructor
        public DeskChair (decimal price, string category, double weight, int seats, int legs, bool spin) 
            : base(price, category, weight, seats, legs)
        {
            Spin = spin;
        }

        //Get-set properties
        //NOTE: Had to assume boolean was the intended type for "Spin", since one wasn't provided in instruction
        public bool Spin
        {
            get; set; //Nothing special is required since booleans will always be set to false by default
        }

        //Override ToString to print statistics
        public override string ToString()
        {
            string ifSpin; 
            if (Spin == true) { ifSpin = "Yes"; } //Set ifSpin to Yes if Spin is True         
            else { ifSpin = "No"; } //Set ifSpin to No if Spin is False

            string ToStringValue = $"Category: {Category}" +
                $"\nWeight: {Weight} lb." +
                $"\nNumber of Seats: {Seats}" +
                $"\nNumber of Legs: {Legs}" +
                $"\nDoes It Spin: {ifSpin}" +
                $"\nPrice: ${Price}";

            return ToStringValue; //Return the specified string above
        }
    }

    public class Cushion
    {
        //Backing fields
        private string mat;
        private double hght, wdth, lngth;

        public Cushion (string material, double height, double width, double length)
        {
            Material = material;
        }

        //Get-set properties
        public string Material
        {
            get { return this.mat; }
            set
            {
                var materialList = new List<string>{"Foam", "Stuffing"};
                if (materialList.Contains(value, StringComparer.OrdinalIgnoreCase)) //If value is foam or stuffing...
                { this.mat = value /*char.ToUpper(value[0]) + value.Substring(1)*/; } //Return value (Capitalized?)
                //If it isn't foam or stuffing, throw an exception
                else { throw new ArgumentOutOfRangeException("The furniture's material is invalid. Please set it as foam or stuffing."); }
            }
        }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }

        //Override ToString to print statistics
        public override string ToString()
        {
            string ToStringValue = $"Material: {Material}" +
                $"\nDimensions: {Length} x {Width} x {Height} inches" +
                $"\nVolume: {CalcVolume()} inches cubed";

            return ToStringValue; //Return the specified string above
        }

        //Custom function to calculate volume of cushion
        public double CalcVolume()
        {
            return Height * Width * Length; //Return the product of height, width, & length
        }
    }
}
