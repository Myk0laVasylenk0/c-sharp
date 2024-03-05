
// Task 3

// Дана строкова послідовність. Знайти суму довжин усіх рядків, що входять в дану послідовність.

using System;
using System.Linq;

class Program
{
    static void Main()
    {

        Console.WriteLine("Task 3: \n");
        // Example sequence of strings
        string lines = "Each flower a wilting sun\nThe death of a new day is never kind\nGrief ain’t no song\nNo loss is this romantic";

        Console.WriteLine(lines + "\n");
        
        string[] sequence = lines.Split("\n");

        

        // Using LINQ to find the sum of the lengths of all strings in the sequence
        int sumOfLengths = sequence.Sum(s => s.Length);

        // Output the result
        Console.WriteLine($"the sum of the lengths of all lines is: {sumOfLengths}");

        Console.ReadKey();

    }
}