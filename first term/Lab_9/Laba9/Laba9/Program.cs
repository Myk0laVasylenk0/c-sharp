
// Task 1: Створити програму яка буде з’єднувати два текстових файли в один.


using System.IO;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

string source_path1 = @"C:\Users\Nicolay\Desktop\KPI\C#\Lab_9\source1.txt";
string source_path2 = @"C:\Users\Nicolay\Desktop\KPI\C#\Lab_9\source2.txt";
string destination_path = @"C:\Users\Nicolay\Desktop\KPI\C#\Lab_9\destination.txt";

void unite_two_files(string path1, string path2, string destination)
{
    string text1, text2;
    StreamReader sr1 = new StreamReader(path1);
    text1 = sr1.ReadToEnd();
    StreamReader sr2 = new StreamReader(path2);
    text2 = sr2.ReadToEnd();
    StreamWriter sr3 = new StreamWriter(destination, true);
    sr3.Write(text1);
    sr3.Write(text2);
    sr1.Close();
    sr2.Close();
    sr3.Close();
}

unite_two_files(source_path1, source_path2, destination_path);



// Task 2: Дано текстовий файл, в кожному рядку якого записано одне або кілька слів.
//Створити підпапку з назвою першого рядка файлу в ній створити нові текстові файли де назва це перше слово з рядка,
//якщо уже є така назва то берем два слова, якщо немає двох слів в рядку то добавляємо цифру по порядку



string source_path = @"C:\Users\Nicolay\Desktop\KPI\C#\Lab_9\source3.txt";
StreamReader source_file = new StreamReader(source_path);
string[] lines = source_file.ReadToEnd().Split("\n");
string[][] matrix = new string[lines.Length][];
for (int k = 0; k < lines.Length; k++)
{
    string[] lst = lines[k].Split(" ");
    matrix[k] = lst;
}
Console.WriteLine(matrix);

string dirpath = @"C:\Users\Nicolay\Desktop\KPI\C#\Lab_9" + @"\" + lines[0];
dirpath = dirpath.Replace("\r", "");
if (!Directory.Exists(dirpath))
{
    Directory.CreateDirectory(dirpath);
}

int i = 0;
foreach (string[] line in matrix)
{

    if (line.Length == 1)
    {
        string filename = string.Join("", matrix[i]).Replace("\r", "");

        if (!File.Exists(dirpath + @"\" + filename + ".txt"))
        {
            FileStream f = File.Create(dirpath + @"\" + filename + ".txt");
        }
        else
        {
            int j = 1;
            while (File.Exists(dirpath + @"\" + filename + j + ".txt"))
            {
                j++;
            }
            FileStream f = File.Create(dirpath + @"\" + filename + j + ".txt");
        }
    }
    else if (line.Length == 2)
    {
        string filename_init = string.Join("", matrix[i][0]).Replace("\r", "");
        string filename = string.Join(" ", matrix[i]).Replace("\r", "");
        
        if (!File.Exists(dirpath + @"\" + filename_init + ".txt"))
        {
            FileStream f = File.Create(dirpath + @"\" + filename_init + ".txt");
        }
        else if (!File.Exists(dirpath + @"\" + filename + ".txt"))
        {
            FileStream f = File.Create(dirpath + @"\" + filename + ".txt");
        }
        else
        {
            int j = 1;
            while (File.Exists(dirpath + @"\" + filename + j + ".txt"))
            {
                j++;
            }
            FileStream f = File.Create(dirpath + @"\" + filename + j + ".txt");
            //f.Close();
        }
    }
    i++;  

} 

Console.ReadKey();

// Task 3: Розробити блок-схему алгоритму програми з завдання 1



