// Определить являются ли введенные с клавиатуры символы правильной записью целого числа. Вычислить сумму цифр введенного числа

string s = Console.ReadLine();
int testnum = 0;
int sum = 0;

// Делаем проверку на целое число (не уверен в оптимальности данного способа):
foreach (char c in s)
    if (char.IsDigit(c)) testnum++;
if (testnum == s.Length)
    System.Console.WriteLine($"Значение {s} является целым числом");
else System.Console.WriteLine($"Значение {s} не является целым числом");

// Конвертируем в массив инт:
char[] ss = s.ToCharArray();
int[] n = new int[ss.Length]; // Array.ConvertAll<char, int>(ss, Convert.ToInt32);
for (int i = 0; i < n.Length; i++)
{
    n[i] = Convert.ToInt32(ss[i].ToString());
    sum += n[i];
}
System.Console.WriteLine($"Сумма чисел равна: {sum}");

// Когда присваиваю значение n[i] он присваивает не само число а ее код в системе. 
// Например для 1 - 49. Никак не могу понять, как это поправить.