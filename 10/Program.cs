// Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

System.Console.Write("Введите значение а: ");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Последняя цифра числа а: "+a%10);