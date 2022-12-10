// Подсчитать сколько раз определенный символ (например 'a') встречается в строке.

System.Console.Write("Введите значение с клавиатуры: ");
string s = Console.ReadLine();
char a = 'a';
int count = 0;

char[] c = s.ToCharArray();
for (int i = 0; i < c.Length; i++)
{
    if (c[i] == 'a') count++;
}
System.Console.WriteLine($"Количество повторяющихся символов \"{a}\", равно: {count}");