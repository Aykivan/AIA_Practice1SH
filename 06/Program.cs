// Написать программу вычисления значения функции y = sin(a). (Класс Math).

Console.Write("Введите значение а: ");
double a=Convert.ToDouble(Console.ReadLine()); 
/* вещественные числа необходимо вводить в зависимости от региональных настроек Windous
Панель управления/Региональные стандарты (ввести в поиске) */
double y=Math.Sin(a);
System.Console.WriteLine($"Sin {a} будет равен: {y} ");
