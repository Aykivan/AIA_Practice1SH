// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int[] RandomArray(int size = 5, int min = 0, int max = 10)
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

int Min(int[] a)
{
    int min = a[0];
    for (int i = 1; i < a.Length; i++)
        if (a[i] < min) min = a[i];
    return min;
}

int Max(int[] a)
{
    int max = a[0];
    /*for (int i = 0; i < a.Length; i++)
        if (a[i] > max) max = a[i];*/
    foreach (int el in a)
        if (el > max) max = el;
    return max;
}

int[] a = RandomArray();
Print(a);
System.Console.WriteLine();

System.Console.WriteLine($"Разница между max и min эл. массива равна: {Max(a) - Min(a)}");