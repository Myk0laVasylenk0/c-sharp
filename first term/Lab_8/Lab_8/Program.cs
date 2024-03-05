
// Laboratory work 8


// Task 1
// Ввести прізвище, ім'я та по батькові в одну строку. Вивести ім'я, по батькові та кількість букв у прізвищі. 
// Вивести найкоротше слово. Вивести рядок без пропусків. Скільки букв в імені? Вивести довжини трьох слів.
// Вивести ім'я та кількість букв у прізвищі.


// Task 2
// Великі цілі числа зручніше читати, коли цифри в них розділені на трійки комами.
// Переформатувати цілі числа в тексті на вивести оновлений текст на екран. 1234 => 1,234 ; 12345678 => 12,345,678



using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {

        // Task 1 
        Console.WriteLine("Task 1");
        Console.WriteLine("\n");
        string data = "Vasylenko Mykola Oleksandrovych";
        string[] data_arr = data.Split(" ");
        Console.WriteLine($"first name: {data_arr[1]}, middle name: {data_arr[2]}");
        Console.WriteLine($"char count in surename: {data_arr[0].Length}");
        int i = 0;
        int char_count = data_arr[0].Length;
        for (int j = 0; j < data_arr.Length; j++)
        {
            if (data_arr[j].Length < char_count)
            {
                i = j;
            }
        }
        Console.WriteLine($"shortest word: {data_arr[i]}");
        string stripped_data = data.Replace(" ", "");
        Console.WriteLine(stripped_data);
        Console.WriteLine($"char count in first name: {data_arr[1].Length}");
        Console.WriteLine($"char counts in three words: {data_arr[0].Length}, {data_arr[1].Length}, {data_arr[2].Length}");
        Console.WriteLine($"first name: {data_arr[1]}, length of surname: {data_arr[0].Length}");

        Console.WriteLine('\n');
        Console.WriteLine("---------------------------------------------------------------------");
        Console.WriteLine("\n");

        // Task 2

        Console.WriteLine("Task 2");
        Console.WriteLine("\n");
        string text = "first number: 12345 second number: 1234567 third one: 123456789.";
        string pattern = @"(?<=\d)(?=(\d\d\d)+(?!\d))";
        string target = ",";
        Regex regex = new Regex(pattern);   
        string result = regex.Replace(text, target);
        Console.WriteLine("Initial text with numbers");
        Console.WriteLine(text);
        Console.WriteLine("Modified text with numbers");
        Console.WriteLine(result);
        Console.ReadKey();

    }

}




