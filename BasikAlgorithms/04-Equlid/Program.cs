// Алгоритм Евклида

/* Без подпрограммы
int a = 125;
int b = 275;

while (a!=b) //! - обратное значение, то есть не равно 
{
    if (a < b)
        b = b - a;
    else
        a = a - b;
}
System.Console.WriteLine(a);*/

int k = 0;
int GCD(int a, int b) // Алгоритм Евклида + счетчик операций
{
    while (a != b)
    {
        k++;
        if (a < b)
            b = b - a;
        else
            a = a - b;
    }
    return a;
}

int QuickGCD(int a, int b) // Ускоренный алгоритм Евклида + счетчик операций
{
    while (a != 0 && b != 0)
    {
        k++;
        if (a < b)
            b = b % a;
        else
            a = a % b;
    }
    return a + b;
}

System.Console.WriteLine(GCD(45, 25));
System.Console.WriteLine(k);
System.Console.WriteLine();
k = 0;
System.Console.WriteLine(QuickGCD(45, 25));
System.Console.WriteLine(k);