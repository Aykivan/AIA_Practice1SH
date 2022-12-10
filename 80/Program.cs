// 80. Вывести на экран кодировку символов по ASCII(с 32 до 122)

char c = 'a';
for (int i = 32; i <= 122; i++)
{
    c = (char)i; //Convert.ToChar(i);
    System.Console.WriteLine(c);
}