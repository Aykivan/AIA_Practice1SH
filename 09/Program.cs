// Вывести на экран четные числа от 1 до N

System.Console.Write("Введите число N: ");
int N=Convert.ToInt32(Console.ReadLine());
int i=2;
System.Console.WriteLine($"Числа от 1 до {N} через цикл while: ");
while (i<=N)
{
    System.Console.Write($"{i} ");
    i=i+2; //i++ аналогично i=i+1
}
System.Console.WriteLine();
Console.WriteLine($"Числа от 1 до {N} через цикл for: ");
for(int j=1;j<=N;j++) //цикл for аналогичен циклу while, его преиммущество - запись в одну строчку переменной(int j=1), условия(j<=N), действия(j++)
{
    if(j%2==0)
    {
        System.Console.Write($"{j} ");
    }
}

/*
В данном случае цикл while является более оптимальным, так как там мы используем меньше действий, по сравнению с циклом for
условие if(j%2==0) - это: если остаток от деления j на 2 равен 0, то выводим j
*/