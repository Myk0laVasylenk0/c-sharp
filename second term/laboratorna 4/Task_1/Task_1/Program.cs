using System;
using Task_1;


// Створити об'єкт класу Простий дріб, використовати клас Число, Знак.
// Методи: висновок на екран, додавання, віднімання, множення, ділення.


class Program
{
    static void Main(string[] args)
    {
        // Create two fractions
        SimpleFraction fraction1 = new SimpleFraction(1, 2); // Represents 1/2
        SimpleFraction fraction2 = new SimpleFraction(3, 4); // Represents 3/4

        Console.WriteLine("Fraction 1: " + fraction1.ToString());
        Console.WriteLine("Fraction 2: " + fraction2.ToString());

        // Add fractions
        SimpleFraction sum = fraction1.Add(fraction2);
        Console.WriteLine($"Sum: {sum}");

        // Subtract fractions
        SimpleFraction difference = fraction1.Subtract(fraction2);
        Console.WriteLine($"Difference: {difference}");

        // Multiply fractions
        SimpleFraction product = fraction1.Multiply(fraction2);
        Console.WriteLine($"Product: {product}");

        // Divide fractions
        SimpleFraction quotient = fraction1.Divide(fraction2);
        Console.WriteLine($"Quotient: {quotient}");
    }
}