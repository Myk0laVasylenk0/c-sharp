
// Task 2

// Написати програму для пошуку однакових значень пари ключ-значення. Вхідний словник записати у JSON


using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        // Initializating of dictionary
        var inputDict = new Dictionary<string, string>();

        inputDict.Add("key1", "value1");
        inputDict.Add("key2", "value2");
        inputDict.Add("key3", "value1");
        inputDict.Add("key4", "value3");
        inputDict.Add("key5", "value2");

        // Serialize the input dictionary to JSON
        string jsonInput = JsonConvert.SerializeObject(inputDict, Formatting.Indented);

        // Write the input JSON to a file
        File.WriteAllText(@"C:\Users\Nicolay\Desktop\KPI\C#\second term\laboratorna 1\task-2\input.json", jsonInput);

        Console.WriteLine("Output dictionary has been saved to output.json");

        // Find keys with the same values and group them
        var outputDict = new Dictionary<string, List<string>>();
        foreach (var kvp in inputDict)
        {
            if (!outputDict.ContainsKey(kvp.Value))
            {
                outputDict[kvp.Value] = new List<string>();
            }
            outputDict[kvp.Value].Add(kvp.Key);
        }

        // Serialize the output dictionary to JSON
        string jsonOutput = JsonConvert.SerializeObject(outputDict, Formatting.Indented);

        // Write the output JSON to a file
        File.WriteAllText(@"C:\Users\Nicolay\Desktop\KPI\C#\second term\laboratorna 1\task-2\output.json", jsonOutput);

        Console.WriteLine("Output dictionary has been saved to output.json");

        Console.ReadKey();  
    }
}