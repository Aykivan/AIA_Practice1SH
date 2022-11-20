// Найти сумму чисел от 1 до А
// Сделал 2 вида условий. while в подпрограмме, for в программе.

// Подпрограмма:
int Sum(int S)
{
    int count = 0;
    int sum = 0;
    while (count <= S)
    {
        sum = sum + count;
        count++;
    }
    return sum;
}

// Программа:
System.Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int count = 0; count <= A; count++)
{
    sum = sum + count;
}
System.Console.WriteLine($"(for) Сумма чисел от 1 до {A} равна: {sum}");
System.Console.WriteLine($"(while) Сумма чисел от 1 до {A} равна: {Sum(A)}");