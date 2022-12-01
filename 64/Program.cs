// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.

// Как я понял, нужен массив с двухзначными числами, числа которые состоят из двух четных элементов
// необходимо заменить на квадраты данных чисел

int[,] RandomArray(int r, int c, int min = 10, int max = 98)
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
            System.Console.Write($"{a[i, j],7}");
        System.Console.WriteLine();
    }
}

void Sqrt(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(0); j++)
            if (a[i, j] % 2 == 0 && a[i, j] / 10 % 2 == 0) a[i, j] = a[i, j]*a[i, j];
}

int n = 4;
int k = 4;
int[,] array = RandomArray(n, k);
PrintArray(array);
System.Console.WriteLine();

Sqrt(array);
PrintArray(array);