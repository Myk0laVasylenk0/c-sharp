using System.Collections.Generic;
using System.Linq;

public static class SequenceHelper
{
    public static (List<int> FirstSubsequence, List<int> SecondSubsequence) SeparateSequence(List<int> sequence, int index)
    {
        if (index < 0 || index >= sequence.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index must be within the sequence range.");
        }

        // Using LINQ to partition the sequence
        List<int> firstSubsequence = sequence.Take(index + 1).ToList();
        List<int> secondSubsequence = sequence.Skip(index + 1).ToList();

        return (firstSubsequence, secondSubsequence);
    }
}

class Program
{
    static void Main()
    {
        List<int> sequence = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int splitIndex = 4; // Example index

        var (FirstSubsequence, SecondSubsequence) = SequenceHelper.SeparateSequence(sequence, splitIndex);

        Console.WriteLine($"First Subsequence: {string.Join(", ", FirstSubsequence)}");
        Console.WriteLine($"Second Subsequence: {string.Join(", ", SecondSubsequence)}");
    }
}