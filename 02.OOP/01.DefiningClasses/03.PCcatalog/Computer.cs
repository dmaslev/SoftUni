using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PCcatalog
{
    class Computer
    {
        private string name;
        private List<Component> components = new List<Component>();
        private decimal price;
        public double Price = 0;

        public Computer(string name, List<Component> components)
        {
            this.Name = name;

            this.Components = components;
            foreach (Component component in Components)
            {
                Price += component.Price;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Computer  name can not be null");
                }
                this.name = value;
            }
        }

        public List<Component> Components
        {
            get { return components; }
            set
            {
                if (value == null) { throw new ArgumentNullException("Value cannot be null", "Components"); }
                components = value;
            }
        }

        public override string ToString()
        {

            string result = String.Format("Name: {0}\nComponents: \n", this.Name);
            foreach (Component component in Components)
            {
                result += component.Name.ToString() + component.Price.ToString() + "\n";
            }

            result += string.Format("Total price: {0:C2}", this.Price);
            return result;
        }
    }
}
