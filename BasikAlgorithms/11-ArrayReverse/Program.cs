// Переворот массива

int[] RandomArray(int size = 4, int min = 0, int max = 10)
{
    int[] a = new int[size];
    for (int i = 0; i < a.Length; i++) a[i] = new Random().Next(min, max);
    return a;
}

void PrinArray(int[] a)
{
    for (int i = 0; i < a.Length; i++) System.Console.Write($"{a[i],5}");
}

void Swap(ref int a, ref int b) // Подпрограмма обмена с использованием ref
{
    int t = a; // Временная переменная для обмена
    a = b;
    b = t;
}

void Reverse(int[] a) // Подпрограмма переворота массива
{
    for (int i = 0; i < a.Length / 2; i++) Swap(ref a[i], ref a[a.Length - 1 - i]);
}

void ReverseSwap(int[] a) // Можно было не писать подпрограмму Swap, сделать все с помощью одной подпрограммы
{
    int t;
    for (int i = 0; i < a.Length / 2; i++)
    {
        t = a[i];
        a[i] = a[a.Length - 1 - i];
        a[a.Length - 1 - i] = t;
    }
}

int[] array = RandomArray();
PrinArray(array);
System.Console.WriteLine();

// ReverseSwap(array);
// Reverse(array); - Наш способ переварота
array = array.Reverse().ToArray(); // Встроенная программа переварота массива Reverse - инструкции по перевороту
                                   // которые начинают работать только совместно с преобразованием в массив 
PrinArray(array);