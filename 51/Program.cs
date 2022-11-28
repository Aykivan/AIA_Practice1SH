// С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

int[] Array(int size)
{
    int[] a = new int[size];
    int count = 1; // Счетчик для вывода текста
    for (int i = 0; i < a.Length; i++)
    {
        System.Console.Write($"Введите {count} число: ");
        a[i] = Convert.ToInt32(Console.ReadLine());
        count++;
    }
    return a;
}

void PrintArray(int[] a)
{
    System.Console.WriteLine("\nВведенные числа: ");
    for (int i = 0; i < a.Length; i++) System.Console.Write($"{a[i]}; ");
}

int Count(int[] a)
{
    int count = 0;
    // for (int i=0;i<a.Length;i++) 
    foreach (int el in a) if (el > 0) count++;
    return count;
}

System.Console.Write("Введите количество чисел: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] a = Array(N);
PrintArray(a);
System.Console.WriteLine($"\nКоличество чисел больше 0, равно: {Count(a)}");