// Вывести на экран таблицу квадратов чисел от 1 до N

//Подпрограмма:
int SquareN(int SN)
{
    SN=(int)Math.Pow(SN,2); // Можно было записать формулой: SN=SN*SN, решил поумничать + добавил явное преобразование
    return SN;
}

//Программа:
System.Console.Write("Введите число N: ");
int N=Convert.ToInt32(Console.ReadLine());

int count=1;
while (count<=N)
{
    //int square=SquareN(count); - изначально делал через доп. переменную
    System.Console.WriteLine($"Квадрат числа {count} - {SquareN(count)}" );
    count++;
}