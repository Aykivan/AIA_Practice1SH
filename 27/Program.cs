// Возведите число А в натуральную степень B используя цикл
// Добавил цикл - for в подпрограмму, цикл - while в программу

// Подпрограмма:
int Exp(int number, int degree)
{
    int ex = 1;
    for (int b = 0; b < degree; b++)
    {
        ex = ex * number;
    }
    return ex;
}

// Программа:
System.Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень числа: ");
int B = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Число {A} в степени {B} будет равно: {Exp(A,B)}");