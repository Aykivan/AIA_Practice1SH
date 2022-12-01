// Написать подпрограмму, которая в квадратной матрице чисел находит сумму элементов главной диагонали

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

// Вариант из практики:
int SumMD(int[,] a)
{
    int sum = 0;
    if (a.GetLength(0) != a.GetLength(1))
        throw new ArgumentException("Матрица не квадратная");
    for (int i = 0; i < a.GetLength(0); i++) sum += a[i, i];
    return sum;
}

// Мой вариант:
int SumMainDiagonal(int[,] a)
{
    int sum = 0;
    int i = 0;
    int j = 0;
    while (i < a.GetLength(0) && j < a.GetLength(1))
    {
        sum = sum + a[i, j];
        i++;
        j++;
    }
    return sum;
}

int row = 4;
int colum = 4;
int[,] array = RandomArray(row, colum);
PrintArray(array);
System.Console.WriteLine($"Сумма чисел главной диагонали равна: {SumMainDiagonal(array)}");
System.Console.WriteLine($"Сумма чисел главной диагонали равна: {SumMD(array)}");