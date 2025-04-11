namespace CIS200_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CPU cpu1 = new CPU("Manufacturer a", "CPU a", 1, "Socket a", 4);
            CPU cpu2 = new CPU("Manufacturer b","CPU c", 2, "Socket b", 5);
            CPU cpu3 = new CPU("CPU c", 3, "Socket c", 6);

            Laptop lap1 = new Laptop("Manufacturer a",cpu1,"Model a",7);
            Laptop lap2 = new Laptop("Manufacturer b", cpu1, "Model b", 8);
            Laptop lap3 = new Laptop("Manufacturer c", cpu2, "Model c", 9);
            Laptop lap4 = new Laptop("Manufacturer d", cpu3, "Model d", 10);

            List<Computer> compList = new List<Computer>();
            compList.Add(lap1);
            compList.Add(lap2);
            compList.Add(lap3);
            compList.Add(lap4);

            foreach (var comp in compList)
            {
                Console.WriteLine(comp.ToString() + "\n----------------------------------------\n");
            }
        }
    }

    public class CPU
    {
        //Backing fields
        private string manu, mode, sock;
        private int clockSp, powerDr;

        //CPU class constructor
        public CPU(string manufacturer, string model, int clockSpeed, string socket, int powerDraw)
        {
            Manufacturer = manufacturer;
            Model = model;
            ClockSpeed = clockSpeed;
            Socket = socket;
            PowerDraw = powerDraw;
        }

        //Alternative CPU class constructor (exclude manufacutrer)
        public CPU(string model, int clockSpeed, string socket, int powerDraw)
        {
            Manufacturer = "Unknown"; //Sets manufacturer to an empty string
            Model = model;
            ClockSpeed = clockSpeed;
            Socket = socket;
            PowerDraw = powerDraw;
        }

        //Get-set properties
        public string Manufacturer
        {
            get { return this.manu; }
            set
            {
                if (String.IsNullOrWhiteSpace(value)) //If value is null/empty or comprised of empty spaces...
                {
                    //Throw an out-of-range exception
                    throw new ArgumentOutOfRangeException("The [Manufacturer] field is invalid. Please make sure it is filled out.");
                }
                else
                {
                    //If valid, return the trimmed value
                    this.manu = value.Trim();
                }
            }
        }
        public string Model
        {
            get { return this.mode; }
            set
            {
                if (String.IsNullOrWhiteSpace(value)) //If value is null/empty or comprised of empty spaces...
                {
                    //Throw an out-of-range exceptin
                    throw new ArgumentOutOfRangeException("The [Model] field is invalid. Please make sure it is filled out.");
                }
                else
                {
                    //If valid, return the trimmed value
                    this.mode = value.Trim();
                }
            }
        }
        public int ClockSpeed
        {
            get { return this.clockSp; }
            set
            {
                if (value < 0) //If value is a negative number...
                {
                    //Throw an out-of-range exception
                    throw new ArgumentOutOfRangeException("The [ClockSpeed] field is invalid. Please make sure it is a positive number.");
                }
                else
                {
                    //If valid, then return the value as-is
                    this.clockSp = value;
                }
            }
        }
        public string Socket
        {
            get { return this.sock; }
            set
            {
                if (String.IsNullOrWhiteSpace(value)) //If value is null/empty or comprised of empty spaces
                {
                    //Throw an out-of-range exception
                    throw new ArgumentOutOfRangeException("The [Socket] field is invalid. Please make sure it is filled out.");
                }
                else
                {
                    //If valid return the trimmed value
                    this.sock = value.Trim();
                }
            }
        }
        public int PowerDraw
        {
            get { return this.powerDr; }
            set
            {
                if (value < 0) //If value is a negative number...
                {
                    //Throw an out-of-range exception
                    throw new ArgumentOutOfRangeException("The [PowerDraw] field is invalid. Please make sure it is a positive number.");
                }
                else
                {
                    //If valid, then return the value as-is
                    this.powerDr = value;
                }
            }
        }

        //Override a pre-built function to display CPU class details
        public override string ToString()
        {
            string ToStringValue = $"{Manufacturer} {Model} " +
                $"\nClock Speed: {ClockSpeed} MHz" +
                $"\nSocket: {Socket}" +
                $"\nPower Draw: {PowerDraw} Watt";
            return ToStringValue;
        }
    }

    public abstract class Computer
    {
        //Backing fields
        private string manu;
        private CPU cPU;

        //Computer class constructor
        public Computer(string manufacturer, CPU cPU)
        {
            Manufacturer = manufacturer;
            CPU = cPU;
        }

        //Get-set properties
        public string Manufacturer
        {
            get { return this.manu; }
            set
            {
                //If value is null/empty, throw out-of-range exception
                if (value == null) { throw new ArgumentOutOfRangeException(""); }
                else { this.manu = value; } //Otherwise, return value
            }
        }

        public CPU CPU
        {
            get { return this.cPU; }
            set
            {
                //If value is null/empty, throw out-of-range exception
                if (value == null) { throw new ArgumentOutOfRangeException(""); }
                else { this.cPU = value; } //Otherwise, return value
            }
        }

        //Create an abstract function, only used for Laptop child class
        public abstract int CalcTDP();

        //Override a pre-built function to display Computer and CPU class details
        public override string ToString()
        {
            string ToStringValue = $"Computer: {Manufacturer}" +
                $"\n\nCPU: {CPU.Manufacturer} {CPU.Model} " +
                $"\nClock Speed: {CPU.ClockSpeed} MHz" +
                $"\nSocket: {CPU.Socket}" +
                $"\nPower Draw: {CPU.PowerDraw} Watt";
            return ToStringValue;
        }
    }

    public class Laptop : Computer
    {
        //Laptop class constructor; pass appropriate variables to parent Computer constructor
        public Laptop(string manufacturer, CPU cpu, string laptopModel, int tDP) : base(manufacturer, cpu)
        {
            LaptopModel = laptopModel;
            TDP = tDP;
        }

        //Get-set properties, without checks as instructed
        public string LaptopModel { get; set; }
        public int TDP { get; set; }

        //Create function to return the TDP value
        public override int CalcTDP() { return TDP; }
        //Override a pre-built function to display Laptop, Computer, and CPU class details
        public override string ToString()
        {
            string ToStringValue = $"Laptop: {LaptopModel}" +
                $"\nThermal Design Power: {TDP} Watts" +
                $"\n\nComputer: {Manufacturer}" +
                $"\n\nCPU: {CPU.Manufacturer} {CPU.Model} " +
                $"\nClock Speed: {CPU.ClockSpeed} MHz" +
                $"\nSocket: {CPU.Socket}" +
                $"\nPower Draw: {CPU.PowerDraw} Watts";
            return ToStringValue;
        }
    }
}
