// Вывести числа от 1 до N, без использования цикла

void loop(int N, int i) // Loop - цикл
{
    if (i <= N)
    {
        System.Console.WriteLine(i);
        loop(N, i + 1);
    }
}
loop(10, 1);