using Task_2.Models;
using Task_2.Management;
using Task_2.Utilities;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        SmartphoneManager manager = new SmartphoneManager();

        // Initialize sample smartphones
        InitializeSampleSmartphones(manager);

        // Demonstrating Sorting
        Console.WriteLine("\n=== Sorted by Model ===");
        DisplayPhones(manager.SortBy("model"));

        Console.WriteLine("\n=== Sorted by Manufacturer ===");
        DisplayPhones(manager.SortBy("manufacturer"));

        Console.WriteLine("\n=== Sorted by Display Size ===");
        DisplayPhones(manager.SortBy("displaysize"));

        // Demonstrating Finding
        Console.WriteLine("\n=== Find Phone by Price Range ===");
        foreach (var phone in manager.FindByPriceRange(500, 1000))
        {
            Console.WriteLine(phone);
        }

        // Demonstrating File Operations
        const string filePath = "./smartphones.json";
        Console.WriteLine("\n=== Saving Phones to File ===");
        FileStorage.SaveToJson(manager.GetAllSmartphones(), filePath);

        Console.WriteLine("=== Loading Phones from File ===");
        var loadedPhones = FileStorage.LoadFromJson<SmartphoneBase>(filePath);
        foreach (var phone in loadedPhones)
        {
            Console.WriteLine(phone);
        }

        // Display Total Stock
        Console.WriteLine($"\n=== Total Stock: {manager.CalculateTotalStock()} ===");
    }

    static void InitializeSampleSmartphones(SmartphoneManager manager)
    {
        manager.AddSmartphone(new IPhone("iPhone 12", 6.1f, 799, 10));
        manager.AddSmartphone(new SamsungGalaxy("Galaxy S21", 6.2f, 999, 15));
        manager.AddSmartphone(new Xiaomi("Mi 11", 6.81f, 749, 20));
        manager.AddSmartphone(new OnePlus("OnePlus 9", 6.55f, 729, 25));
    }

    static void DisplayPhones(IEnumerable<SmartphoneBase> phones)
    {
        foreach (var phone in phones)
        {
            Console.WriteLine(phone);
        }
    }
}