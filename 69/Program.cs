// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

int[,] RandomArray(int r, int c, int min = 0, int max = 9)
{
    int[,] a = new int[r, c];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = random.Next(min, max + 1);
    return a;
}

void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],3}");
        System.Console.WriteLine();
    }
}

void SortArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
        for (int k = 0; k < a.GetLength(0); k++)
            for (int j = 0; j < a.GetLength(1) - 1; j++)
                if (a[i, j] < a[i, j + 1])
                {
                    int t = a[i, j];
                    a[i, j] = a[i, j + 1];
                    a[i, j + 1] = t;
                }

}

int n = 4;
int k = 4;
int[,] array = RandomArray(n, k);
PrintArray(array);
System.Console.WriteLine();

SortArray(array);
PrintArray(array);