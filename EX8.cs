Console.WriteLine("Enter n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
int[,] arr4 = new int[n, m];
FillArray(arr4, 1, 5);
PrintArray(arr4);
Console.WriteLine();
PrintRow(arr4);


void FillArray(int[,] array0, int minimum, int maximum)
{
    Random random = new Random();
    for (int i = 0; i < array0.GetLength(0); i++)
    {
        for (int j = 0; j < array0.GetLength(1); j++)
        {
            array0[i, j] = random.Next(minimum, maximum);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintRow(int[,] array)
{
    int sum = 0;
    int minSum = sum;
    int currentI = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];

        }
        if (minSum > sum)
        {
            minSum = sum;
        }
        currentI = i;
    }
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[currentI, j]} ");
    }
}