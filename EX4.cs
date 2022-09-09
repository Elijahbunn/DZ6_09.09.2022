Console.WriteLine("Enter n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
int[,] arr4 = new int[n, m];
FillArray(arr4, 1, 5);
PrintArray(arr4);

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
    double[] summ = new double[m];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
            summ[j] += array[i, j];
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int j = 0; j < m; j++)
    {
        Console.WriteLine($"Среднее арифметическое {j+1}-ого столбца: {summ[j] / n}");
    }
}