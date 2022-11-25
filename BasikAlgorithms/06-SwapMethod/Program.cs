void Swap(ref int a, ref int b) // reference-ссылка
{
    int t = a;
    a = b;
    b = t;
}

void Calculator(int a, int b, out int sum, out int mult) // out - дает возможность не присваивать до вычисления значения переменным 
                                                         // работает аналогично с ref
{
    sum = a + b;
    mult = a * b;
}

int a = 2, b = 5;
System.Console.WriteLine($"а={a} b={b}");

Swap(ref a, ref b);
System.Console.WriteLine($"а={a} b={b}");

int sum = 0, mult = 0;
Calculator(a, b, out sum, out mult);