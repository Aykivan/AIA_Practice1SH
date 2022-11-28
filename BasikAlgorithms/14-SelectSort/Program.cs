// Сортировка выбором

int[] RandomArray(int size = 5, int min = 0, int max = 10)
{
    int[] a = new int[size];
    for (int i = 0; i < a.Length; i++) a[i] = new Random().Next(min, max);
    return a;
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++) System.Console.Write($"{a[i],5}");
    System.Console.WriteLine();
}

void SelectSort(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        for (int j = i+1; j < a.Length; j++)
        {
            int im = i;
            if (a[im] < a[j])
            {
                im = j;
                int t = a[i];
                a[i] = a[im];
                a[im] = t;
            }
        }
}

int[] array = RandomArray();
Print(array);

SelectSort(array);
Print(array);