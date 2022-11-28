// Написать программу преобразования десятичного числа в двоичное

string DecInBin(int n)
{
    string s = "";
    if (n == 0) s = "0";
    while (n != 0)
    {
        s = n % 2 + s; // Не явное преобразование из int в string
        n = n / 2;
    }
    return s;
}

System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Число {n} в двоичной системе равно: {DecInBin(n)}");