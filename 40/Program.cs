/* Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. 
Создайте массив, который является произведением пар чисел в одномерном массиве a. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д.*/

int[] RandomArray(int size = 10, int min = 1, int max = 10)
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

int[] NewArray(int[] a, int size)
{
    int[] a2 = new int[size / 2];
    for (int i = 0; i < a2.Length; i++)
    {
        a2[i] = a[i] * a[size - i - 1];
    }
    return a2;
}

System.Console.Write("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] a = RandomArray(N);
Print(a);
System.Console.WriteLine();

int[] a2 = NewArray(a, N);
Print(a2);

// Есть проблема с нечетными массивами. На счет них у меня тут два варианта. 
// Либо сделать проверку на четное количество элементов, и в случае, если оно не соответсвует, просить задать другое значение N
// Либо в случае если массив нечетный сделать, чтобы он центральное значение умножал само на себя. 
// В условиях задачи по этому поводу нечего не говорится. 