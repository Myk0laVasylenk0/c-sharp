using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Number
    {
        public int Value { get; }

        public Number(int value)
        {
            Value = value;
            Console.WriteLine("Creating a Number instance");
        }

        public override bool Equals(object obj)
        {
            Console.WriteLine("Calling Equals on Number");
            if (obj is Number other)
            {
                return this.Value == other.Value;
            }
            return false;
        }

        public override int GetHashCode()
        {
            Console.WriteLine("Getting HashCode for Number");
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            Console.WriteLine("Converting Number to String");
            return Value.ToString();
        }
    }
}
