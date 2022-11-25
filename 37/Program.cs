// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] RandomArray(int size = 10, int min = 100, int max = 1000) 
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i = 0; i < a.Length; i++) a[i] = random.Next(min, max);
    return a;
}
// Поставил макс равный 1000, так как числа в массиве не будут превышать значение - 999

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++) System.Console.Write($"{a[i],5}");
}

int EvenNum(int[] a)
{
    int count = 0;
    foreach (int el in a)
        if (el % 2 == 0) count++;
    return count;
}

int NotEvenNum(int[] a)
{
    int count = 0;
    foreach (int el in a)
        if (el % 2 != 0) count++;
    return count;
}

int[] a = RandomArray();
Print(a);
System.Console.WriteLine();

System.Console.WriteLine($"Количество четных эл. равно: {EvenNum(a)}");
System.Console.WriteLine($"Количество нечетных эл. равно: {NotEvenNum(a)}");