// Подсчитать сумму цифр в числе. Сделать подпрограмму.

// Подпрограмма
int SumN(int S)
{
    int sum = 0;
    while (S > 0)
    {
        sum = sum + S % 10;
        S = S / 10;
    }
    return sum;
}

// Программа
System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
/* int sum = 0;
while (n > 0)
{
    sum = sum + n % 10;
    n = n / 10;
}
System.Console.WriteLine($"Сумма чисел равна {sum}");*/
System.Console.WriteLine($"Сумма чисел равна: {SumN(n)}");