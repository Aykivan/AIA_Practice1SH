// Показать двумерный массив размером m×n заполненный вещественными случайными числами.

double[,] RandomArray(int r, int c, int min = 0, int max = 9)
{
    double[,] a = new double [r, c];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = random.Next(min, max + 1);
    return a;
}

void PrintArray(double[,] a)

{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],3}");
        System.Console.WriteLine();
    }
}

int m=3;
int n=4;
double[,] array = RandomArray(m, n);
PrintArray(array);

// Вот вроде все работает, однако я хотел сделать арументы r и с в RandomArray типом double, но почему-то он выдает мне ошибку,
// что не может их неявно преобразовать из double в int, хотя я менял тип данных и вводимых аргументов m и n.
// Не смог разобраться.