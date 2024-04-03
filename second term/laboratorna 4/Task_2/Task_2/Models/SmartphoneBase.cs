using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Models
{
    public abstract class SmartphoneBase
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public float DisplaySize { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        protected SmartphoneBase(string model, string manufacturer, float displaySize, decimal price, int stock)
        {
            Model = model;
            Manufacturer = manufacturer;
            DisplaySize = displaySize;
            Price = price;
            Stock = stock;
        }

        public override string ToString()
        {
            return $"{Manufacturer} {Model} - Display: {DisplaySize}\", Price: ${Price}, Stock: {Stock}";
        }
    }
}
