﻿// Программа проверяет пятизначное число на палиндромом.

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a / 10000 == a % 10)
{
    if (a / 1000 % 10 == a / 10 % 10)
    {
        System.Console.WriteLine("Число является палинромом");
    }
    else System.Console.WriteLine("Число не является палиндромом");
}
else System.Console.WriteLine("Число не является палиндромом");

// Программа рабочая, однако насколько она оптимальна и задумывалось ли ее решать именно так, другой вопрос.
// Надеюсь в 3тьей практике показали ее решение.
// P.S. Надеюсь я не слишком искаверкал слово "палиндром".