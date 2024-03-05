

int[,] Matrix = { { 1, 2 }, { 2, 1 }, { 1, 8 }, { 8, 1 }, { 2, 8 }, { 8, 2 }, { 2, 7 }, { 7, 2 }, { 3, 7 }, { 7, 3 }, { 3, 4 }, { 4, 3 }, { 4, 5 }, { 5, 4 }, { 5, 6 }, { 6, 5 }, { 6, 7 }, { 7, 6 } };
int[] V = {1, 2, 3, 4, 5, 6, 7};
int[,] MatrixIn = new int[V.Length, Matrix.GetLength(0)];

Console.WriteLine("Список сумiжностi");
for (int i = 0; i < Matrix.GetLength(0); i++)
{
    for (int j = 0; j < Matrix.GetLength(1); j++)
    {
        Console.Write(Matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Матриця iнцидентностi");
for (int i = 0; i < MatrixIn.GetLength(0); i++)
{
    for (int j = 0; j < MatrixIn.GetLength(1); j++)
    {
        if (V[i] == Matrix[j, 0])
        {
            MatrixIn[i, j] = -1;
        }
        else if (V[i] == Matrix[j, 1])
        {
            MatrixIn[i, j] = 1;
        }
        else if ((V[i] == Matrix[j, 1]) && (V[i] == Matrix[j, 0]))
        {
            MatrixIn[i, j] = 2;
        }
        else
        {
            MatrixIn[i, j] = 0;
        }
        Console.Write(String.Format("{0,3}", MatrixIn[i, j]));
    }

    Console.WriteLine();
}

Console.WriteLine("Степенi вершин");
int entrance = 0;
int exit = 0;
int power = 0;
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
    if (power == 1)
    {
        if (exit == 1)
        {
            Console.WriteLine(V[i] + "-висяча вершина.Степiнь виходу - " + exit);
        }

        else { Console.WriteLine(V[i] + "-висяча вершина.Степiнь входу - " + entrance); }
    }

    else
    {
        Console.WriteLine("Степiнь вершини " + V[i] + "- " + power + ".Степiнь входу - " + entrance + ".Степiнь виходу - " + exit);
    }
    entrance = 0;
    exit = 0;
    power = 0;
}