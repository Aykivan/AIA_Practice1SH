// Вывести на экран числа от -N до N

System.Console.Write("Введите значение N: ");
int N=Convert.ToInt32(Console.ReadLine());
int i=N*-1;
System.Console.WriteLine("Вывод чисел от -N до N, через цикл while:");
while (i<=N)
{
    System.Console.Write($"{i} ");
    i++;
}
System.Console.WriteLine();
System.Console.WriteLine("Вывод чисел от -N до N, через цикл for:");
for (int j=N*-1;j<=N;j++) System.Console.Write($"{j} ");

//В этой задече я нашел решение, однако насколько оно правильно я не знаю, возможно есть способы проще, если есть пожалуйста напишите.