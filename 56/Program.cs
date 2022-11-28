// Написать программу копирования массива

int[] RandomArray(int size = 10, int min = 0, int max = 100)
{
    int[] a = new int[size];
    for (int i = 0; i < a.Length; i++) a[i] = new Random().Next(min, max);
    return a;
}

// Пересмотрел свои лекции, в них способ создания рандомных чисел немного отличался от того, что используете вы.
// Я их обьединил и у меня вышла данная конструкция, мне кажется, что она наиболее оптимальна.
// Хотел бы узнать ваше мнение на этот счет.

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++) System.Console.Write($"{a[i],5}");
    System.Console.WriteLine();
}

int[] CloneArray(int[] origin)
{
    int[] clone = new int[origin.Length];
    for (int i = 0; i < origin.Length; i++) clone[i] = origin[i];
    return clone;
}

int []a=RandomArray();
System.Console.WriteLine("-----------------------------------------------------------------------------------------");
System.Console.WriteLine("Оригинальный массив: ");
Print(a);
int []clone=CloneArray(a);
System.Console.WriteLine("Копия массива: ");
Print(clone);
System.Console.WriteLine("-----------------------------------------------------------------------------------------");