// Обмен значениями 2х переменных

/*Классический способ с 3тьей переменной
int a = 5;
int b = 7;
int temp;

temp=a;
a=b;
b=temp;*/

//Без использования 3тьей переменной:
/*int a=5;
int b=7;
a=a+b;
b=a-b;
a=a-b;
System.Console.WriteLine(a+" "+b);*/

//Загадочный способ, который не пояснили
int a=5;
int b=7;
a=a^b;
b=a^b;
a=a^b;
System.Console.WriteLine($"а={a} и b={b}");