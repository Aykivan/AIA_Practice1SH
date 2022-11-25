// Задать массив из 12 элементов, заполненных числами из [-9, 9]. Найти сумму положительных/отрицательных элементов массив

int[] RandomIntArray(int size, int min, int max) // Заполнение массива случайными числами
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
        a[i] = random.Next(min, max + 1); // +1 так как максимальное значение берется не включительно
    return a;
}

void Print(int[] a) // Вывод массива 
{
    for (int i = 0; i < a.Length; i++)
        System.Console.Write($"{a[i],5}");
}

/* Мой вариант
int count=0;
int SumPositive=0;
int SumNegative=0;

while (count<a.Length)
{
    if (a[count]>0) SumPositive=SumPositive+a[count];
    else SumNegative=SumNegative+a[count];
    count++;
}
System.Console.WriteLine($"Сумма положительных эл. равна: {SumPositive}");
System.Console.WriteLine($"Сумма отрицательных эл. равна: {Math.Abs(SumNegative)}");*/

// Вариант с подпрограммами:
int SumPositive(int[] a)
{
    int s = 0;
    foreach (int el in a)
        if (el > 0) s = s + el;
    return s;
}

int SumNegative(int[] a)
{
    int s = 0;
    foreach (int el in a)
        if (el < 0) s = s + el;
    return s;
}
// Условие foreach позволяет пройтись по всем элементам цикла (el)

int[] a = RandomIntArray(12, -9, 9);
Print(a);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма положительных эл. равна: {SumPositive(a)}");
System.Console.WriteLine($"Сумма положительных эл. равна: {Math.Abs(SumNegative(a))}");