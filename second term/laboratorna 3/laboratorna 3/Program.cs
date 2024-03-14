
// Task 1:

// Створити клас с атрибутами та конструктором. У методі main() ініціалізувати створення
// екземплярів класу та продемонструвати роботу його методів згідно умов завдання.

// Створити клас з двома змінними. Додати конструктор з вхідними параметрами. Додати конструктор, який ініціалізує члени
// класу за замовчуванням. Додати деструктор, що виводить на екран повідомлення про видалення об’єкту.


// Task 2:

//Створити у попередньому завданні два методи з використанням серіалізації та десеріалізації JSON. 

// Метод 1. Зберігає створений об’єкт класу з Завдання 1 у JSON файл 
// Метод 2. Відкриває JSON файл з даними та створює об’єкт класу з цими даними для виконання Завдання 1.





//using Computer;

//var hardware = new Hardware("MyClient", 1, "MyLabel", 12345);
//hardware.ConvertToJson(@"C:\Users\Nicolay\Desktop\KPI\C#\second term\laboratorna 3\hardware.json");

//var newHardware = Hardware.GetFromJson(@"C:\path_to_your_file\hardware.json");
//Console.WriteLine($"Client: {newHardware.client}, Serial Number: {newHardware.serial_num}");



using Computer;

public class Program
{
    public static void Main(string[] args)
    {
    
        Init();

        GC.Collect();
        Console.ReadLine();
    }

    public static void Init()
    {
        Hardware hardware = new Hardware("Joe Cage", 1, "PC", 12345);
        hardware.ConvertToJson(@"C:\Users\Nicolay\Desktop\KPI\C#\second term\laboratorna 3\hardware.json");

        Hardware newHardware = Hardware.GetFromJson(@"C:\Users\Nicolay\Desktop\KPI\C#\second term\laboratorna 3\hardware2.json");
        Console.WriteLine("Printing info from Json:");
        Console.WriteLine($"Client: {newHardware.client}, Serial Number: {newHardware.serial_num}, Label: {newHardware.label}, " +
            $"Client ID: {newHardware.client_id}");
    }
}

//public class Class1
//{
//    public Class1()
//    {
//        Console.WriteLine("call constructotr...");
//    }
//    ~Class1()
//    {
//        Console.WriteLine("call destructor...");
//    }
//}









