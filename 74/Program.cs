// Найти сумму цифр числа

int SumDigital(int N)
{
    if (N == 0) return N;
    else return SumDigital(N / 10) + N % 10;
}
System.Console.WriteLine(SumDigital(123));