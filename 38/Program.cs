// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// Не совсем уловил суть задачи. Получается, что из 123 случайных чисел, мне нужно посчитать количество чисел равных диапазону от 10 до 99

int[] RandomArray(int size = 10, int min = 0, int max = 200)
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

int Count(int[] a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
        if (a[i] > 10 && a[i] < 99) count++;
    return count;
}

int []a=RandomArray();
Print(a);
System.Console.WriteLine();

System.Console.WriteLine($"Количество чисел, входящих в диапазон от 10 до 99, равно: {Count(a)}");