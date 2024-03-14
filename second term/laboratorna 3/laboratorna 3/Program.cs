
using Computer;

// Testing our Hardware class
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










