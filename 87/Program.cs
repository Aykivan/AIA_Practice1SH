// Удалить среднюю букву при нечетное длине строки и две средние буквы при четной длине строки

string s = Console.ReadLine();
int m = s.Length / 2;
string s1;
if (s.Length % 2 == 0)
{
    s1 = s.Remove(m - 1, 2);
}
else
{
    s1 = s.Remove(m, 1);
}
System.Console.WriteLine(s1);