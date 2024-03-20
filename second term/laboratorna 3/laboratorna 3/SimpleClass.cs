
// Task 1:

// Створити клас с атрибутами та конструктором. У методі main() ініціалізувати створення
// екземплярів класу та продемонструвати роботу його методів згідно умов завдання.

// Створити клас з двома змінними. Додати конструктор з вхідними параметрами. Додати конструктор, який ініціалізує члени
// класу за замовчуванням. Додати деструктор, що виводить на екран повідомлення про видалення об’єкту.


// Task 2:

//Створити у попередньому завданні два методи з використанням серіалізації та десеріалізації JSON. 

// Метод 1. Зберігає створений об’єкт класу з Завдання 1 у JSON файл 
// Метод 2. Відкриває JSON файл з даними та створює об’єкт класу з цими даними для виконання Завдання 1.


using Newtonsoft.Json;

namespace Computer
{
    public class Hardware
    {

        // Initializing 4 attributes of Hardware class
        public string client;
        public int client_id;
        public string label;
        public int serial_num;

        // Constructor 1: initializing object with default parameters
        public Hardware()
        {
            client = "unknown client";
            client_id = 0;
            label = "undefined label";
            serial_num = 0;
        }

        // Constructor 2: initializing object with given parameters
        public Hardware(string client, int client_id, string label, int serial_num)
        {
            this.client = client;
            this.client_id = client_id;
            this.label = label;
            this.serial_num = serial_num;
        }

        // Method 1: serialize this instance of Hardware class and save to a JSON file
        public void ConvertToJson(string filePath)
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(filePath, json);
            Console.WriteLine("serialized this instance of Hardware class and saved to a JSON file");
        }

        // Method 2: create an instance of Hardware clas from a JSON file
        public static Hardware GetFromJson(string filePath)
        {
            // Print a message to the console
            Console.WriteLine("created an instance of Hardware clas from a JSON file");

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Hardware>(json);
        }

        // Destructor (finalizer): destroy object and return appropriate message
        ~Hardware(){

            Console.WriteLine("instance of Hardware clas was deleted");
        }
    }
}
