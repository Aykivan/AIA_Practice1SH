// Бинарный поиск в массиве он же двоичный поиск

// Линейный поиск просматривает все элементы поочередно
// Бинарный поиск осуществляется за счет деления максимального значения числа на 2. Из 1000 вариантов найдет за 10 попыток (2^10=1024)

int[] RandomArray(int size = 10, int min = 0, int max = 10)
{
    int[] a = new int[size];
    for (int i = 0; i < a.Length; i++) a[i] = new Random().Next(min, max);
    return a;
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++) System.Console.Write($"{a[i],5}");
}

int BinSearch(int[] a, int find)
{
    int i;
    int left = 0;
    int right = a.Length - 1;
    i = left + (right - left) / 2;
    while (a[i] != find && left < right)
    {
        if (find > a[i]) left = i + 1;
        else right = i;
        i = left + (right - left) / 2;
    }
    if (a[i] != find) return -1;
    else return i;
}

int find = 11;
int[] array = RandomArray();
array[7] = 11;
Array.Sort(array); // Сортировка от меньшего к большему
System.Console.WriteLine("    0    1    2    3    4    5    6    7    8    9");
Print(array);
System.Console.WriteLine($"\n{BinSearch(array, find)}");