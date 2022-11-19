// По двум заданным числам проверять является ли одно квадратом другого.

System.Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a * a == b) System.Console.WriteLine($"Число {b} является квадратом числа {a}");
else
{
    if (b * b == a) System.Console.WriteLine($"Число {a} является квадратом числа {b}");
    else System.Console.WriteLine("Не является");
}
//Условие в условии