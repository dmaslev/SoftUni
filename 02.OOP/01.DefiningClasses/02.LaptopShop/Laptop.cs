using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class Laptop
    {
        public string model;

        public string manufacturer;

        public string processor;

        public string ram;

        public string graphicsCard;

        public string hdd;

        public string screen;

        public double price;

        public Battery battery;

        public Laptop(string model, double price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, double price, string manufacturer, string processor, string ram, string graphicsCard, string hdd, string screen , Battery battery) 
            : this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hdd;
            this.Screen = screen;
            this.Battery = battery;
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))   throw new ArgumentNullException("Invalid model");
                this.model = value;
            }
        }
        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)  throw new ArgumentException("Price must be positive number");
                this.price = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Invalid Manufacturer");
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Invalid Processor value");
                this.processor = value;
            }
        }

        public string RAM
        {
            get { return this.ram; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Invalid RAM value");
                this.ram = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Invalid value for Graphic Card");
                this.graphicsCard = value;
            }
        }

        public string HDD
        {
            get { return this.hdd; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Invalid value for HDD");
                this.hdd = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Invalid value for screen");
                this.screen = value;
            }
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(manufacturer))
            {
                return string.Format("{0, -10}|{1}\n{2,-10}|{3} lv.", "model", this.model, "price", this.price);
            }
            string firstLine = string.Format("{0,-14}|{1}\n", "model", this.model);
            string secondLine = string.Format("{0,-14}|{1}\n", "manufacturer", this.manufacturer);
            string thirdLine = string.Format("{0,-14}|{1}\n", "processor", this.processor);
            string fourthLine = string.Format("{0,-14}|{1}\n", "RAM", this.ram);
            string fifthLine = string.Format("{0,-14}|{1}\n", "graphics card", this.graphicsCard);
            string SixthLine = string.Format("{0,-14}|{1}\n", "HDD", this.hdd);
            string SeventhLine = string.Format("{0,-14}|{1}\n", "screen", this.screen);
            string eighthLine = string.Format("{0,-14}|{1}\n", "battery", this.battery.Type);
            string ninthLine = string.Format("{0,-14}|{1}\n", "battery life", this.battery.Hours);
            string tenthLine = string.Format("{0,-14}|{1} lv.", "price", this.price);
            return firstLine + secondLine + thirdLine + fourthLine + fifthLine + SixthLine + SeventhLine + eighthLine + ninthLine + tenthLine;
        }
      
    }
}
