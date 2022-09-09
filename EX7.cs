Console.WriteLine("Enter n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
int[,] arr4 = new int[n, m];
FillArray(arr4, 1, 10);
PrintArray(arr4);
Console.WriteLine();
RebuildArray(arr4);
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void RebuildArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            if (n == m)
            {
                int tmp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = tmp;
            }
        }
    }
    if (n != m)
    {
        Console.WriteLine("Matrix imposible rebuilding");
        Console.WriteLine();
    }
}