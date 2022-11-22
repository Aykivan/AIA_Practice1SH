// Написать программу вычисления произведения чисел от 1 до N

// Подпрограмма:
int Factorial(int n)
{
    int count = 1;
    int fact = 1;
    while (count <= n)
    {
        fact = fact * count;
        count++;
    }
    return fact; 
}

// Программа:
System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Произведение чисел от 1 до {N} равно: {Factorial(N)}");