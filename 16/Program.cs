// Дано число. Проверить кратно ли оно 7 и 23

System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 7 == 0 && n % 23 == 0)
{
    System.Console.WriteLine(n + "/7=" + n / 7);
    System.Console.WriteLine(n + "/23=" + n / 23);
    System.Console.WriteLine($"Число {n} кратно 7 и 23");
}
else System.Console.WriteLine($"Число {n} не кратно числам: 7 и 23");

/*Решение с практики 
int n = Convert.ToInt32(Console.ReadLine());
if (n % 7 == 0 && n % 23 == 0) System.Console.WriteLine("Yes"); else System.Console.WriteLine("No");*/

/*В случае, если бы было сложное условие можно было бы поступить так:
int n = Convert.ToInt32(Console.ReadLine());
bool d1=n%7==0;
bool d2=n%23==0;
if (d1 && d2) System.Console.WriteLine("Yes"); else System.Console.WriteLine("No");*/