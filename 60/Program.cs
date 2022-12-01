// Показать двумерный массив размером m×n заполненный целыми случайными числами

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

System.Console.Write("Введите значение м: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = RandomArray(m, n);
PrintArray(array);