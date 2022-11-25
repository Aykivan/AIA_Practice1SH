// Расчитать среднюю температуру за неделю
/*

int t1, t2, t3, t4, t5, t6, t7;
double s=0; 
t1=Convert.ToInt32(Console.ReadLine());
t2=Convert.ToInt32(Console.ReadLine());
t3=Convert.ToInt32(Console.ReadLine());
t4=Convert.ToInt32(Console.ReadLine());
t5=Convert.ToInt32(Console.ReadLine());
t6=Convert.ToInt32(Console.ReadLine());
t7=Convert.ToInt32(Console.ReadLine());
s=(t1+t2+t3+t4+t5+t6+t7)/7;
System.Console.WriteLine(s);*/

// маасив - это обьект, значит после него можно поставить точку
int N = 7; // Вводим переменную для определения длинны массива 
double s = 0;
int[] t; // Создали маасив, которому еще не присвоенно значение
t = new int[N];
// int [] t =new int [N] - можно записать в одну строчку
// Заполняем массив
for (int i = 0; i < t.Length; i++) // t.Length - длинна массива используется вместо N
    t[i] = Convert.ToInt32(Console.ReadLine());
// Обрабатываем его
for (int i = 0; i < t.Length; i++)
    s = s + t[i];
// Выводим результат
System.Console.WriteLine(s / t.Length);