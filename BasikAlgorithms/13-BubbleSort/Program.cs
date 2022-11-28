// Пузырьковая сортировка

// Сравнивает два ближайших значения и меняет их в зависимости от вида сортировки

int[] RandomArray(int size = 10, int min = 0, int max = 10)
{
    int[] a = new int[size];
    for (int i =0; i < a.Length; i++) a[i] = new Random().Next(min, max);
    return a;
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++) System.Console.Write($"{a[i],5}");
    System.Console.WriteLine();
}

void BubbleSort(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        for (int j = 0; j < a.Length - 1; j++)
        {
            if (a[j] > a[j + 1])
            {
                int t = a[j];
                a[j] = a[j + 1];
                a[j + 1] = t;
            }
        }
}

int[] array = RandomArray();
Print(array);

BubbleSort(array);
Print(array);