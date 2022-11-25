// Задать массив из 8 целых элементов и вывести их на экран

int[] RandomArray(int size, int min = 0, int max = 100) // Наполнение массива
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i = 0; i < a.Length; i++)
        a[i] = random.Next(min, max);
    return a;
}

void Print(int[] a) // Вывод массива
{
    for (int i = 0; i < a.Length; i++)
        System.Console.Write($"{a[i],5}");
}

int[] a = RandomArray(8);
Print(a);