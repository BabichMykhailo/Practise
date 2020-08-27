using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopList
{
    public class Laptop
    {
        public double Price { get; set; } 
        public string Model { get; set; }
        public string Color { get; set; }
    
        public Laptop(double price, string model, string color)
        {
            Price = price;
            Model = model;
            Color = color;
        }

        public override string ToString()
        {
            return $"{Price} Price, {Model} Model, {Color} Color";
        }
    }

    
}
