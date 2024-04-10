using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_1
{
    public class SimpleFraction
    {
        public Number Numerator { get; private set; }
        public Number Denominator { get; private set; }
        public Sign Sign { get; private set; }

        public SimpleFraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }

            Sign = numerator * denominator >= 0 ? Sign.Positive : Sign.Negative;
            Numerator = new Number(Math.Abs(numerator));
            Denominator = new Number(Math.Abs(denominator));
            Console.WriteLine("Creating a SimpleFraction instance");
        }


        public SimpleFraction Add(SimpleFraction other)
        {
            Console.WriteLine("Adding fractions");
            // Find LCM of the two denominators (for simplicity, using product here)
            int commonDenominator = this.Denominator.Value * other.Denominator.Value;

            // Adjust numerators to the common denominator
            int adjustedNumerator1 = this.Numerator.Value * other.Denominator.Value;
            int adjustedNumerator2 = other.Numerator.Value * this.Denominator.Value;

            // Add adjusted numerators
            int sumNumerator = adjustedNumerator1 + adjustedNumerator2;

            // Create new fraction with sum
            return new SimpleFraction(sumNumerator, commonDenominator);
        }



        public SimpleFraction Subtract(SimpleFraction other)
        {
            Console.WriteLine("Subtracting fractions");
            // Find LCM of the two denominators (for simplicity, using product here)
            int commonDenominator = this.Denominator.Value * other.Denominator.Value;

            // Adjust numerators to the common denominator
            int adjustedNumerator1 = this.Numerator.Value * other.Denominator.Value;
            int adjustedNumerator2 = other.Numerator.Value * this.Denominator.Value;

            // Subtract adjusted numerators
            int differenceNumerator = adjustedNumerator1 - adjustedNumerator2;

            // Create new fraction with difference
            return new SimpleFraction(differenceNumerator, commonDenominator);
        }


        public SimpleFraction Multiply(SimpleFraction other)
        {
            Console.WriteLine("Multiplying fractions");
            int newNumerator = this.Numerator.Value * other.Numerator.Value;
            int newDenominator = this.Denominator.Value * other.Denominator.Value;
            bool newSignIsPositive = this.Sign.GetIsPositive() == other.Sign.GetIsPositive();
            return new SimpleFraction(newSignIsPositive ? Math.Abs(newNumerator) : -Math.Abs(newNumerator), newDenominator);
        }
        

        public SimpleFraction Divide(SimpleFraction other)
        {
            Console.WriteLine("Dividing fractions");
            if (other.Numerator.Value == 0)
            {
                throw new ArgumentException("Cannot divide by a fraction with a numerator of zero.");
            }
            // Multiply by the reciprocal of the other fraction
            int newNumerator = this.Numerator.Value * other.Denominator.Value;
            int newDenominator = this.Denominator.Value * other.Numerator.Value;
            bool newSignIsPositive = this.Sign.GetIsPositive() == other.Sign.GetIsPositive();
            return new SimpleFraction(newSignIsPositive ? Math.Abs(newNumerator) : -Math.Abs(newNumerator), Math.Abs(newDenominator));
        }

        public override bool Equals(object obj)
        {
            Console.WriteLine("Calling Equals on SimpleFraction");
            if (obj is SimpleFraction other)
            {
                return this.Numerator.Equals(other.Numerator) && this.Denominator.Equals(other.Denominator) && this.Sign.Equals(other.Sign);
            }
            return false;
        }

        public override int GetHashCode()
        {
            Console.WriteLine("Getting HashCode for SimpleFraction");
            return HashCode.Combine(Numerator, Denominator, Sign);
        }

        public override string ToString()
        {
            Console.WriteLine("Converting SimpleFraction to String");
            string signString = Sign.GetIsPositive() ? "" : "-";
            return $"{signString}{Numerator.Value}/{Denominator.Value}";
        }
    }
}
