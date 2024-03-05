
// Laboratory work 7


// Task1:
// У поїзді 7 вагонів, в кожному по 36 місць. Інформація про продані на поїзд квитки зберігається в двовимірному масиві,
// номери рядків якого відповідають номерам вагонів, а номери стовпців - номерам місць. Якщо місце продане, то відповідний елемент
// масиву має значення 1, в іншому випадку - 0. Скласти програму, що визначає, чи є вільні місця в тому чи іншому вагоні поїзда.
// Зайняті місця заповнити рандомно.

Console.WriteLine("Task 1");
Console.WriteLine();
Random random = new Random();  

int[,] train = new int[7, 10];  // better output when num of seats is set to 10 (not skewed)
int rows = train.GetUpperBound(0) + 1;  
int columns = train.GetUpperBound(1) + 1;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        train[i, j] = random.Next(0, 2);
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{train[i, j]} \t");
    }
    Console.WriteLine();
}

static bool IsVacantPlace(int Carriage, int Seat, int[,] train_array)
{
    bool is_vacant = false;
    if (Carriage - 1 >= 0 && Carriage - 1 < 6 && Seat - 1 >= 0 && Seat - 1 < 35)
    {
        if (train_array[Carriage - 1, Seat - 1] == 0)
        {
            is_vacant = true;
        }
    }
    return is_vacant;
}

bool answer = IsVacantPlace(1, 1, train);
Console.WriteLine();

Console.WriteLine($"Is selected seat vacant: {answer}");
Console.WriteLine();
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine();



// Task2:
//Заповнити матрицю випадковими числами. Відобразити ліву половину матриці на праву дзеркально симетрично щодо вертикальної осі. 

Console.WriteLine("Task 2");
Console.WriteLine();
int n, m;
Console.Write("rows = ");
n = int.Parse(Console.ReadLine());
Console.Write("columns = ");
m = int.Parse(Console.ReadLine());

Console.WriteLine();

int[,] matrix = new int[n, m];
int rows_m = matrix.GetUpperBound(0) + 1;
int columns_m = matrix.GetUpperBound(1) + 1;

for (int i = 0; i < rows_m; i++)
{
    for (int j = 0; j < columns_m; j++)
    {
        matrix[i, j] = random.Next(0, 11);
    }
}

Console.WriteLine("Initial matrix:");
Console.WriteLine(); 

for (int i = 0; i < rows_m; i++)
{
    for (int j = 0; j < columns_m; j++)
    {
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Modified matrix:");
Console.WriteLine();    



    for (int i = 0; i < rows_m; i++)
    {
        for (int j = 0; j < columns_m / 2; j++)
        {
            matrix[i, columns_m - 1 - j] = matrix[i, j];
        }
    }

//else
//{
//    for (int i = 0; i < rows_m; i++)
//    {
//        for (int j = 0; j < (int)(columns_m / 2); j++)
//        {
//            matrix[i, columns_m - 1 - j] = matrix[i, j];
//        }
//    }
//}

for (int i = 0; i < rows_m; i++)
{
    for (int j = 0; j < columns_m; j++)
    {
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}
Console.ReadKey();




// Task3:
//Навчитися керувати програмою в режимі дебагінга. Під час здачі лаби запустити вашу програму в цьому режимі
//і на прикладі двох попередніх завдань покроково продемонструвати роботу вашої програми

