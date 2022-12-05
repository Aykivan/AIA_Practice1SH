// Факториал от 1 до N, через рекурсию

/*
int N = 10;
int F = 1;
int i = 1;
void Factorial(int N, int F, int i)
{
    if (i < N + 1)
    {
        F = F * i;
        System.Console.WriteLine(F);
        Factorial(N, F, i + 1);
    }
}
Factorial(N, F, i); */

int F(int N)
{
    if (N == 0) return 1;
    else return F(N - 1) * N;
}
System.Console.WriteLine(F(5));