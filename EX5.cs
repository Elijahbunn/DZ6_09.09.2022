Console.WriteLine("Enter n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
int[,] arr4 = new int[n, m];
int[,] arrayCopy = new int[n, m];
FillArray(arr4, 1, 5);
PrintArray(arr4);
Console.WriteLine();
CopyArray(arr4, arrayCopy);
PrintArray(arrayCopy);

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

void CopyArray(int[,] arrayOrig, int[,] arrayCopy)
{

    for (int j = 0; j < arrayCopy.GetLength(1); j++)
    {
        arrayCopy[0, j] = arrayOrig[n - 1, j];
        arrayCopy[n - 1, j] = arrayOrig[0, j];

        for (int i = 1; i < arrayCopy.GetLength(0) - 1; i++)
        {
            arrayCopy[i, j] = arrayOrig[i, j];
        }

    }
}