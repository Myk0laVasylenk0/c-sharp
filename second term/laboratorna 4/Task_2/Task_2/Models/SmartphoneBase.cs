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

        // Virtual method to describe the unique feature of the smartphone
        public virtual string DescribeUniqueFeature()
        {
            return $"{Manufacturer} {Model} has no specific unique features listed.";
        }

        public override string ToString()
        {
            return $"{Manufacturer} {Model} - Display: {DisplaySize}\", Price: ${Price}, Stock: {Stock}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (SmartphoneBase)obj;
            return Model == other.Model &&
                   Manufacturer == other.Manufacturer &&
                   DisplaySize == other.DisplaySize &&
                   Price == other.Price &&
                   Stock == other.Stock;
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 17;
                // Suitable nullity checks etc, of course :)
                hash = hash * 23 + Manufacturer.GetHashCode();
                hash = hash * 23 + Model.GetHashCode();
                hash = hash * 23 + DisplaySize.GetHashCode();
                hash = hash * 23 + Price.GetHashCode();
                hash = hash * 23 + Stock.GetHashCode();
                return hash;
            }
        }
    }
}
