// С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго (блок-схема)

System.Console.Write("Введите число а: ");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите число b: " );
double b=Convert.ToDouble(Console.ReadLine());

/* Памятка условия
полное условие
if ()
{
    true
}
else
{
    false
}
не полное условие
if ()
{
    true
}*/

if (a*a==b) 
{
    System.Console.WriteLine($"{b} является квадратом {a}");
}
if (b*b==a)
{
    System.Console.WriteLine($"{a} является квадратом {b}");
}
//можно указать и без скобок
