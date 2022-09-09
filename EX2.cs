Console.WriteLine("Enter number: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] A = new int[n, n];
for (int i = 0; i < A.GetLength(0); i++)
{
    for (int j = 0; j < A.GetLength(1); j++)
    {
        A[i, j] = (i + j) % n + 1;
        Console.Write($"{A[i, j]} ");
    }
    Console.WriteLine();
}