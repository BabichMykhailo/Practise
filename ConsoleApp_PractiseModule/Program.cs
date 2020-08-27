using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using LaptopList;

namespace ConsoleApp_PractiseModule
{
    class Program
    {
        static void Main(string[] args)
        {
            double price;
            string model, color;
            
            while (true)
            {
                Console.WriteLine("Press any key to add laptop, press <escape> to quit. Press <i> for info");
                ConsoleKeyInfo P = Console.ReadKey();
                
                if (P.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else if (P.Key == ConsoleKey.I)
                {
                    foreach(var l in LaptopCollection.Laptops)
                    {
                        Console.WriteLine(l);
                    }
                }
                else
                {
                    Console.WriteLine("Enter price");
                    Double.TryParse(Console.ReadLine(), out price);

                    Console.WriteLine("Enter laptop model ");
                    model = Console.ReadLine();

                    Console.WriteLine("Enter color");
                    color = Console.ReadLine();

                    LaptopCollection.Laptops.Add(new Laptop(price, model, color));
                }
            }

        }
    }
}
