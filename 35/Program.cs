// Написать программу замены элементов массива на противоположные

int[] RandomArray(int size = 5, int min = -100, int max = 100)
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

/* Решение с выводом
int[] Opposite(int[] a) 
{
    for (int i = 0; i < a.Length; i++) a[i] = -a[i];
    return a;
}*/

// Без вывода
void Opposite(int[] a)
{
    for (int i = 0; i < a.Length; i++) a[i] = -a[i];
}

int[] a = RandomArray();
Print(a);
System.Console.WriteLine();

// Решение с выводом
// int[] a2 = Opposite(a); 
// Print(a2);
Opposite(a);
Print(a);

// Как я понял, в случае с выводом массива мы дублируем первый массив и выводим его копию
// А если мы применяем void, то мы изменяем наш текущий массив и выводим его измененную версию