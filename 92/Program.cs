// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно 
// (в случае, если матрица не квадратная).

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

int[,] ConvertArray(int[,] origin)
{
    int[,] convert = new int[origin.GetLength(0), origin.GetLength(1)];
    for (int i = 0; i < origin.GetLength(0); i++)
    {
        for (int j = 0; j < origin.GetLength(1); j++)
        {
            convert[j, i] = origin[i, j];
        }
    }
    return convert;
}

int row = 4;
int colum = 4;
int[,] array = RandomArray(row, colum);

if (row == colum)
{
    System.Console.WriteLine("Первоначальный массив: ");
    PrintArray(array);
    System.Console.WriteLine();

    int[,] convertarray = ConvertArray(array);
    System.Console.WriteLine("Перевернутый массив: ");
    PrintArray(convertarray);
}
else System.Console.WriteLine("Заданный массив невозможно перевернуть");