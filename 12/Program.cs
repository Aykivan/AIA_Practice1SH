// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

System.Console.Write("Введите число от 10 до 99: ");
int a=Convert.ToInt32(Console.ReadLine());
if(a/10>a%10) System.Console.WriteLine("Наибольшая из цифр в данном числе: "+a/10);
else System.Console.WriteLine("Наибольшая из цифр в данном числе: "+a%10);