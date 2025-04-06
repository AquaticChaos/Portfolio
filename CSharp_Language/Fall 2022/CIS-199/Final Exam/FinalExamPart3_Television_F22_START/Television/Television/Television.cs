using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Television
{
    public class Television
    {

        private string _brand, _model;
        private double _screensize, _price, _power, _usage;
        private bool _isSmartTV;
        
        public string Brand 
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public double ScreenSize 
        {
            get { return _screensize; }
            set
            {
                if(value < 0) { value = 0; }
                _screensize = value;
            }
        }
        public double Price 
        {
            get { return _price; }
            set
            {
                if (value < 0) { value = 0; }
                _price = value;
            }
        }
        public double Power
        {
            get { return _power; }
            set
            {
                if (value < 0) { value = 0; }
                _power = value;
            }
        }
        public double Usage
        {
            get { return _usage; }
            set
            {
                if (value < 0) { value = 0; }
                _usage = value;
            }
        }
        public Television(string brand, string model, double screensize, double price, int power, int usage) 
        {
            _brand = brand;
            _model = model;
            _screensize = screensize;
            _price = price;
            _power = power;
            _usage = usage;
        }
        public void NotSmartTV() 
        {
            _isSmartTV = false;
        }
        public void IsSmartTV()
        {
            _isSmartTV = true;
        }
        public bool SmartTv()
        {
            return _isSmartTV;
        }
        public double PowerPerHour()
        {
            return ((Power * Usage) / 1000);
            // usage of the televison in kWh
            //Example: (30Watts x 8hrs) % 1000 = 0.24kWh
        }
        public override string ToString()
        {
            string _outputString = "Brand: " + this.Brand;
            _outputString += "\nModel: " + this.Model;
            _outputString += "\nScreen Size: " + this.ScreenSize + " in.";
            _outputString += "\nPrice: " + this.Price.ToString("C");
            _outputString += "\nPower: " + this.Power + " Watts";
            _outputString += "\nAverage Usage: " + this.Usage + " Hrs";
            _outputString += "\nSmart TV: " + this.SmartTv();
            _outputString += "\nkWh: " + this.PowerPerHour();

            return _outputString;
        }

    }
}
