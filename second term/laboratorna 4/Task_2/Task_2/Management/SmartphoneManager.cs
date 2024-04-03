using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Models;


namespace Task_2.Management
{
    public class SmartphoneManager
    {
        private List<SmartphoneBase> smartphones;

        public SmartphoneManager()
        {
            smartphones = new List<SmartphoneBase>();
        }

        public List<SmartphoneBase> GetAllSmartphones()
        {
            return smartphones;
        }

        public void AddSmartphone(SmartphoneBase phone)
        {
            smartphones.Add(phone);
        }

        public IEnumerable<SmartphoneBase> SortBy(string criterion)
        {
            switch (criterion.ToLower())
            {
                case "model":
                    return smartphones.OrderBy(p => p.Model);
                case "manufacturer":
                    return smartphones.OrderBy(p => p.Manufacturer);
                case "displaysize":
                    return smartphones.OrderBy(p => p.DisplaySize);
                default:
                    throw new ArgumentException("Invalid sort criterion.");
            }
        }

        public IEnumerable<SmartphoneBase> FindByPriceRange(decimal minPrice, decimal maxPrice)
        {
            return smartphones.Where(p => p.Price >= minPrice && p.Price <= maxPrice);
        }

        public SmartphoneBase FindByParameters(string model, string manufacturer, float displaySize)
        {
            return smartphones.FirstOrDefault(p => p.Model == model && p.Manufacturer == manufacturer && p.DisplaySize == displaySize);
        }

        public int CalculateTotalStock()
        {
            return smartphones.Sum(p => p.Stock);
        }
    }
}
