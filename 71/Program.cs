// Показать натуральные числа от N до 1, N задано

void Loop(int N, int i = 1)
{
    if (i <= N)
    {
        System.Console.WriteLine(N);
        Loop(N - 1, i);
    }
}
Loop(5);