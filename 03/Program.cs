// С клавиатуры вводя два числа a и b. Найти максимальное из них.

System.Console.Write("Введите число а: ");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b: ");
int b=Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    System.Console.WriteLine($"Наибольшее число: {a}");
}
else
{
    System.Console.WriteLine($"Наибольшее число: {b}");
}

//Нет уточнения в задачи по поводу равенства чисел. Поэтому, что делать программе в случае равенства я не прописывал.