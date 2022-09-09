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

void RestartArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j % 2 == 0)
            {
                //array[i, j] = Math.Pow(array[i, j], 2);
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
}


int[,] mas3 = new int[4, 4];
FillArray(mas3, 1, 10);
PrintArray(mas3);
RestartArray(mas3);
Console.WriteLine();
PrintArray(mas3);