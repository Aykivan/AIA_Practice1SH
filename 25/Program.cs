// Вывести на экран кубы чисел от 1 до N
// Так как решение этой задачи от предыдущей отличается заменой одной цифры, решил добавить счетчик

// Подпрограмма куба:
int CubicN(int CN)
{
    CN = (int)Math.Pow(CN, 3); // CN=CN*CN*CN;
    return CN;
}

// Подпрограмма - счетчик:
int Count(int C)
{
    int n = 0;
    while (n < C)
    {
        n++;
    }
    return C=n;
}

// Программа:
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int count = 1;
while (count <= N)
{
    System.Console.WriteLine($"Куб числа {count} - {CubicN(count)}");
    count++;
}
System.Console.WriteLine($"Количество посчитанных чисел - {Count(N)}");