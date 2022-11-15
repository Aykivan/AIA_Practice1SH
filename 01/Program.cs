/*ОписаниеWL
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

System.Console.WriteLine("впва"); //WriteLine - это метод
System.Console.WriteLine("выфв","ывыфв"); //значения можно выводить через запятую
System.Console.WriteLine("выфв"+"выфв"+2+"выф"); // а так же можно склеивать строки между собой 
*/

/*Переменные
int a=0, b=0, c=0; // целые числа  
float f=20.4f; //32 бит вещесвенный 
double d=3.14; //64 бит вещественный
string s="ывфвф"; //строка
//char c0="в" один символ и должны быть одинарные ковычки?
bool flag=true; //логический
*/

// С клавиатуры вводится целое число. Вывести квадрат числа (блок-схема)

int a; //32 бита ~-2 000 000 000 ... ~+2 000 000 000
a=10;
System.Console.Write("Введите число: ");
string? s=Console.ReadLine();
a=Convert.ToInt32(s); //конвертация string s, которое мы ввели с клавиатуры, в int a
int b=a*a;
System.Console.WriteLine("Число "+a+" в квадрате, равно: "+b); //это более простой метод слияния строк
System.Console.WriteLine($"{a}^2={b}"); //метод итерполяции строк - самый современный, профессиональный