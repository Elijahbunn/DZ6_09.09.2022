void FillArray(double[,] array, int minimum, int maximum)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.NextDouble() * rand.Next(minimum, maximum);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"| {array[i, j]} | ");
        }
        Console.WriteLine();
    }
}

double[,] massive = new double[5, 3];
FillArray(massive, 1, 100);
PrintArray(massive);