// Возведите число А в натуральную степень B используя цикл
// Добавил цикл - for в подпрограмму, цикл - while в программу

// Подпрограмма:
int Exp(int E)
{
    System.Console.Write("Введите степень числа: ");
    int B = Convert.ToInt32(Console.ReadLine());
    int a = 1;
    for (int b = 0; b < B; b++)
    {
        a = a * E;
    }
    return a; 
}

// Программа:
System.Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Число {A} в заданной степени будет равно: {Exp(A)}");