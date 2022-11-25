// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] RandomArray(int size = 6, int min = 0, int max = 10)
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i = 0; i < a.Length; i++) a[i] = random.Next(min, max);
    return a;
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++) System.Console.Write($"{a[i],5}");
}

int Sum(int[] a)
{
    int sum = 0;
    for (int i = 1; i < a.Length; i += 2) sum = sum + a[i];
    return sum;
}

int[] a = RandomArray();
Print(a);
System.Console.WriteLine();

System.Console.WriteLine($"Сумма чисел на нечетных позициях равна: {Sum(a)}");