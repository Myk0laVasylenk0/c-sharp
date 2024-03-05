// Дано масив. Переписати його другий, четвертий і т. д. елементи в інший масив такого ж розміру розташувавши елементи на тих же місцях, що і в вихідному масиві;
// Видалити з масиву максимальний і мінімальний елементи. Написати метод для підрахунку кількості пар сусідніх елементів з однаковими значеннями;

using System;

static int[] GenerateRandomIntArray(int length, int minValue, int maxValue)
{
    Random random = new Random();
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minValue, maxValue);
    }

    return array;
}


int arrayLength = 20;
int minValue = -100;
int maxValue = 101;

int[] randomIntArray = GenerateRandomIntArray(arrayLength, minValue, maxValue);

// Print the array to the console

string result = string.Join(", ", randomIntArray);
Console.WriteLine("Random Array: " + result);

int[] copy_appray = new int[20];

for (int i = 0; i <= randomIntArray.Length; i++)
{
    if ((i + 1) % 2 == 0)
    {
        copy_appray[i] = (int)randomIntArray[i];
    }
}

string result1 = string.Join(", ", copy_appray);
Console.WriteLine("Array Copy: " + result1);

// Finding indexes of the min and max elements

static int FindMinIndex(int[] array)
{
    int minIndex = 0;
    int minValue = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minValue)
        {
            minValue = array[i];
            minIndex = i;
        }
    }

    return minIndex;
}

static int FindMaxIndex(int[] array)
{
    int maxIndex = 0;
    int maxValue = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxValue)
        {
            maxValue = array[i];
            maxIndex = i;
        }
    }

    return maxIndex;
}


int minIndex = FindMinIndex(randomIntArray);
int maxIndex = FindMaxIndex(randomIntArray);

// Printing min and max elements to the console

Console.WriteLine("Min element " + randomIntArray[minIndex]);
Console.WriteLine("Max element " + randomIntArray[maxIndex]);

// Creating array without min and max elements

var MinMaxExcluded = new int[18];

int j = 0;

for (int i = 0; i < randomIntArray.Length; i++)
{
    if (i ==  minIndex | i == maxIndex)
    {
        continue;
    }
    else
    {
        MinMaxExcluded[j] = (int)randomIntArray[i];
        j++;
    }
}

string result2 = string.Join(", ", MinMaxExcluded);
Console.WriteLine("Array without min and max: " + result2);

// Method that counts neighbor pairs with equal elements

static int CountNeighborEqualPairs(int[] array)
{
    int counter = 0;
    int i = 0;
    while (i < array.Length - 1)
    {
        if (array[i] == array[i + 1])
        {
            counter++;
        }
        i++;
    }

    return counter;
}

Console.WriteLine($"{CountNeighborEqualPairs(randomIntArray)} neighbor pairs with equal elements");

Console.ReadKey();