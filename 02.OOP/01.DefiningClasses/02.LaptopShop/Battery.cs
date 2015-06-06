using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class Battery
    {
        private string type;
        private double batteryLife;

        public Battery(string type)
        {
            this.Type = type;
        }

        public Battery(string type, double hours)
            : this(type)
        {
            this.Hours = hours;
        }

        public string Type
        {
            get { return this.type; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("Invalid value for battery type!");
                this.type = value;
            }
        }

        public double Hours
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0) throw new ArgumentException("Battery hours can not be negative");
                this.batteryLife = value;
            }
        }

    }
}
