// Подсчитать количество цифр среди вводимых с клавиатуры символов

string s = Console.ReadLine();
int count = 0;
// for (int i = 0; i < s.Length; i++)
//    if (char.IsDigit(s[i])) count++;
foreach (char c in s)
    if (char.IsDigit(s[i])) count++;
System.Console.WriteLine(count);