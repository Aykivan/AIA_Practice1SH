// С клавиатуры вводятся три числа. Найти максимальное из трех чисел

System.Console.Write("Введите первое число (а): ");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число (b): ");
int b=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число (c): ");
int c=Convert.ToInt32(Console.ReadLine());
int max=a;
if (b>max) max=b;
if (c>max) max=c;
System.Console.WriteLine("При нахождении через условие if, наибольшее число равно: "+max);

max = Math.Max(a, Math.Max(b, c)); //Нешел данный способ в гугле, когда моя программа не работа, решит тоже его закрепить
System.Console.WriteLine("При нахождении, через класс Math, наибольшее число равно: "+max);