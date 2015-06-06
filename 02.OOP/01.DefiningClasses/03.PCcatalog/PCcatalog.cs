using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.PCcatalog
{
    class PCcatalog
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            System.Threading.Thread.CurrentThread.CurrentCulture =
                 System.Globalization.CultureInfo.CreateSpecificCulture("bg-BG");
            List<Computer> computers = new List<Computer>();

            Component ggaphic = new Component("Intel HD Graphics 4400", 150.0);
            Component processor = new Component("Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 120);
            Component motherboard = new Component("Asus AK-47", 180);
            List<Component> components = new List<Component> { ggaphic, processor, motherboard };
            Computer comp1 = new Computer("Lenovo", components);

            ggaphic = new Component("NVIDIA GeForce GTX 880M", 350.0);
            processor = new Component("Intel Core i7-4700HQ", 250);
            motherboard = new Component("Asus Motherboard", 180);
            components = new List<Component> { ggaphic, processor, motherboard };
            Computer comp2 = new Computer("Asus", components);

            ggaphic = new Component("alabala", 2350.0);
            processor = new Component("lqlqlq", 800);
            motherboard = new Component("Asus Motherboard", 1520);
            components = new List<Component> { ggaphic, processor, motherboard };

            Computer comp3 = new Computer("comp3", components);

            computers.Add(comp1);
            computers.Add(comp2);
            computers.Add(comp3);

            computers = computers.OrderBy(x => x.Price).ToList();


            foreach (var computer in computers)
            {
                Console.WriteLine(computer); ;
                Console.WriteLine();
            }
           
            
        }
    }
}
