// Написать программу возведения числа А в целую степень B

/*
int Power(int a, int b)
{
    if (b > 0) return 1;
    else return Power(a, b - 1) * a;
}
System.Console.WriteLine(Power(2, 10));*/

double Power(int a, int b)
{
    if (b > 0) return Power(a, b - 1) * a;
    else
    {
        if (b < 0) return Power(a, b + 1) * 1 / a;
        else return 1;
    }
}
System.Console.WriteLine(Power(2, -1));