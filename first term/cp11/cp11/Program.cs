using System.Runtime.InteropServices;

//Сарабун Марія ІК-33, [11 / 28 / 2023 10:51 PM]
class Graph
{
    static void Main(string[] args)
    {
        int n, m;
        Console.Write("Введiть кiлькiсть вершин n: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Введiть кiлькiсть ребер m: ");
        m = int.Parse(Console.ReadLine());
        Console.WriteLine("Граф орієнтовний/неорієнтовний? Напишіть:" +
                "\n+ якщо граф орієнтовний " +
                "\n- якщо граф неорієнтовний.");
        char type = char.Parse(Console.ReadLine());
        Console.WriteLine("Введіть початкову та кінцеву вершини через кому(приклад: 1, 2)");

        int[,] Matrix = new int[m, 2];

        // Парсимо дані
        for (int i = 0; i < m; i++)
        {
            string s = Console.ReadLine();
            string[] subs = s.Split(", ");
            Matrix[i, 0] = int.Parse(subs[0]);
            Matrix[i, 1] = int.Parse(subs[1]);
        }

        int[] V = GetUniqueVertices(Matrix);

        int[,] MatrixAdj = CreateAdjacencyMatrix(Matrix, V, type, m);

        WriteMatrix("Матриця сумiжностi", MatrixAdj);

        int[,] MatrixIn = CreateIncidenceMatrix(Matrix, V, type, n, m);
        DisplayVertexDegrees(V, MatrixIn, type);

        Console.ReadKey();

    }

    static int[] GetUniqueVertices(int[,] matrix)
    {
        HashSet<int> uniqueChars = new HashSet<int>();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            uniqueChars.Add(matrix[i, 0]);
            uniqueChars.Add(matrix[i, 1]);
        }
        int[] V = new int[uniqueChars.Count];
        uniqueChars.CopyTo(V);
        Array.Sort(V); // Сортуємо вершини
        return V;
    }

    static int[,] CreateAdjacencyMatrix(int[,] matrix, int[] V, char type, int m)
    {
        int n = V.Length;
        int[,] MatrixAdj = new int[n, n];
        for (int i = 0; i < m; i++)
        {
            int vertex1 = matrix[i, 0];
            int vertex2 = matrix[i, 1];

            int index1 = Array.IndexOf(V, vertex1);
            int index2 = Array.IndexOf(V, vertex2);

            MatrixAdj[index1, index2] = 1;
            if (type == '-')
            {
                MatrixAdj[index2, index1] = 1;
            }
        }

        return MatrixAdj;
    }

    static int[,] CreateIncidenceMatrix(int[,] matrix, int[] V, char type, int n, int m)

    {
        Console.WriteLine("Матриця Iнциндентності");
        int[,] MatrixIn = new int[n, m];

        for (int i = 0; i < MatrixIn.GetLength(0); i++)
        {
            for (int j = 0; j < MatrixIn.GetLength(1); j++)
            {
                if (type == '+')
                {
                    if (V[i] == matrix[j, 0])
                    {
                        MatrixIn[i, j] = -1;
                    }
                    else if ((V[i] == matrix[j, 1]) && (V[i] == matrix[j, 0]))
                    {
                        MatrixIn[i, j] = 2;
                    }
                    else if (V[i] == matrix[j, 1])
                    {
                        MatrixIn[i, j] = 1;
                    }
                    else
                    {
                        MatrixIn[i, j] = 0;
                    }
                }

                if (type == '-')
                {
                    if (V[i] == matrix[j, 0] | V[i] == matrix[j, 1])
                    {
                        MatrixIn[i, j] = 1;
                    }
                    else
                    {
                        MatrixIn[i, j] = 0;
                    }
                }
                Console.Write(String.Format("{0,3}", MatrixIn[i, j]));
            }

            Console.WriteLine();
        }
        return MatrixIn;
    }
   //Сарабун Марія ІК-33, [11/28/2023 10:51 PM]

    static void DisplayVertexDegrees(int[] V, int[,] MatrixIn, char type)
    {
        int entrance = 0;
        int exit = 0;
        int power = 0;
        Console.WriteLine("Степенi вершин");
        for (int i = 0; i < MatrixIn.GetLength(0); i++)
        {
            for (int j = 0; j < MatrixIn.GetLength(1); j++)
            {
                if (MatrixIn[i, j] == 1)
                {
                    entrance++;
                    power++;
                }
                else if (MatrixIn[i, j] == -1)
                {
                    exit++;
                    power++;
                }

            }
            if (power == 0)
            {
                Console.WriteLine(V[i] + " - ізольована вершина");
            }
            if (power == 1 && type == '+')
            {
                if (exit == 1)
                {
                    Console.WriteLine(V[i] + "-висяча вершина.Напівсепiнь виходу - " + exit);
                }

                else { Console.WriteLine(V[i] + "-висяча вершина.Напівсепiнь входу - " + entrance); }
            }
            if (power == 1 && type == '-')
            {
                if (exit == 1)
                {
                    Console.WriteLine(V[i] + "-висяча вершина.");
                }

                else { Console.WriteLine(V[i] + "-висяча вершина."); }
            }

            if (power > 1 && type == '+')
            {
                Console.WriteLine("Степiнь вершини " + V[i] + "- " + power + ".Напівсепiнь - " + entrance + ".Напівсепiнь виходу - " + exit);
            }
            if (power > 1 && type == '-')
            {
                Console.WriteLine("Степiнь вершини " + V[i] + "- " + power);
            }
            entrance = 0;
            exit = 0;
            power = 0;
        }
    }

    static void WriteMatrix(string text, int[,] Matrix)
    {
        Console.WriteLine(text);
        for (int i = 0; i < Matrix.GetLength(0); i++)
        {
            for (int j = 0; j < Matrix.GetLength(1); j++)
            {
                Console.Write(Matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

}











