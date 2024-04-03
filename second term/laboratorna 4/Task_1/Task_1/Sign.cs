using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Sign
    {
        private bool IsPositive { get; }

        // Static properties for ease of use
        public static readonly Sign Positive = new Sign(true);
        public static readonly Sign Negative = new Sign(false);

        private Sign(bool isPositive)
        {
            IsPositive = isPositive;
        }

        public static Sign FromBool(bool isPositive)
        {
            return isPositive ? Positive : Negative;
        }

        public override bool Equals(object obj)
        {
            Console.WriteLine("Calling Equals on Sign");
            if (obj is Sign other)
            {
                return this.IsPositive == other.IsPositive;
            }
            return false;
        }

        public override int GetHashCode()
        {
            Console.WriteLine("Getting HashCode for Sign");
            return IsPositive.GetHashCode();
        }

        public override string ToString()
        {
            Console.WriteLine("Converting Sign to String");
            return IsPositive ? "Positive" : "Negative";
        }

        // Helper method to flip the sign
        public Sign Flip()
        {
            return IsPositive ? Negative : Positive;
        }

        public bool GetIsPositive() => IsPositive; // Method to access the sign outside the class
    }
}
