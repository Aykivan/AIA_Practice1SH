// Определить, присутствует ли в заданном массиве, некоторое число

int[] RandomArray(int size = 10, int min = 0, int max = 10)
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i = 0; i < a.Length; i++) a[i] = random.Next(min, max + 1);
    return a;
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++) System.Console.Write($"{a[i],5}");
}

int Find(int[] a, int find)
{
    int i = 0;
    while (i < a.Length && a[i] != find) i++;
    if (i == a.Length) return -1;
    else return i;
}

int[] a = RandomArray();
Print(a);
System.Console.WriteLine();

int find = 10;
int i = Find(a, find);

if (i == -1) System.Console.WriteLine($"Число {find} не найдено");
else System.Console.WriteLine($"Число {find} находится в {i}");