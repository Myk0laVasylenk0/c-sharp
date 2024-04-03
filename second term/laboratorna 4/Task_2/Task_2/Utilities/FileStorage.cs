using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task_2.Utilities
{
    public static class FileStorage
    {
        // Loads a list of objects from a JSON file.
        public static List<T> LoadFromJson<T>(string filePath)
        {
            try
            {
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Objects
                };
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<T>>(json, settings) ?? new List<T>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading from file: {ex.Message}");
                return new List<T>();
            }
        }

        // Saves a list of objects to a JSON file.
        public static void SaveToJson<T>(List<T> objects, string filePath)
        {
            try
            {
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Objects,
                    Formatting = Formatting.Indented
                };
                string json = JsonConvert.SerializeObject(objects, settings);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving to file: {ex.Message}");
            }
        }
    }
}
