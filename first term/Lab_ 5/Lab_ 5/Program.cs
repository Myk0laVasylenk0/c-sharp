
// Створіть метод який буде перевіряти приналежність функції
// f (x) = (x * 5 + x / 10) * 33 / sqrt (x + 5/7), x > 0 проміжку [10: 50]
// в залежності від введеного X. Вивести true або false.
 
void IsInRange(float x)
{
    if (x > 0)
    {
        double y;
        bool answer = false;
        y = (x * 5 + x / 10) * 33 / Math.Sqrt(x + 5 / 7);
        if (y >= 10 && y <= 50)
        {
            answer = true;
        }
        Console.WriteLine($"f (x) = (x * 5 + x / 10) * 33 / sqrt (x + 5/7), x > 0 with x={x} in range[10: 50]: {answer}");
    }
    else
    {
        Console.WriteLine("psarameter x is less than or equal to 0");
    }
    
}

IsInRange(10f);








void MinMaxRoot(double a, double b, double c)
{
    double root_1;
    double root_2;
    double D;
    D = Math.Pow(b, 2) - 4 * a * c;
    if (D > 0)
    {
        root_1 = (-b + D) / 2 * a;
        root_2 = (-b - D) / 2 * a;

        Console.WriteLine($"Min root is: {Math.Min(root_1, root_2)}");
        Console.WriteLine($"Max root is: {Math.Max(root_1, root_2)}");
    }
    else if (D == 0)
    {
        root_1 = -b / 2 * a;
        Console.WriteLine($"We have one root: {root_1}");


    }
    else
    {
        Console.WriteLine("We don't have roots");
    }
}


// Напишіть метод який буде знаходити найбільше та найменше
// значення кореня 10*x^2 - 23/4*x + 6 = 0


double a = 10;
double b = -23/4;
double c = 6;

MinMaxRoot(a, b, c);