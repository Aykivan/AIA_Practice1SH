//  C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки

string s = Console.ReadLine();
int count = 0;

char[] c = s.ToCharArray();
for (int i = 0; i < c.Length; i++)
{
    if (c[i] != '.') count++;
    else break;
}
System.Console.WriteLine($"Количество символов до точки, равно: {count}");