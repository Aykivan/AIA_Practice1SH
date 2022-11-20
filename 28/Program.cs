// Определить количество цифр в числе. Сделать подпрограмму.

// Сам алгоритм:
/* System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
n = Math.Abs(n); // Добавили возможность вводить отрицательные числа

int count = 0;
int n2 = n; // Специально ввел доп. переменную, чтобы при выводе текста была возможность обратиться к первоначальному числу 
if (n == 0) count = 1; // Пограничный случай - при вводе 0, без данной строки, будет выведенно количество цифр 0
while (n2 > 0)
{
    n2 = n2 / 10;
    count++;
}
System.Console.WriteLine($"Количество цифр в числе {n} равно {count}");*/

//Подпрограмма:
int CountDigits(int Number)
{
    Number = Math.Abs(Number);
    int count = 0;
    if (Number == 0) count = 1;
    while (Number > 0)
    {
        Number = Number / 10;
        count++;
    }
    return count;
}

// Основная программа:
System.Console.Write("Введиет число: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Количесвто цифр равно: " + CountDigits(n));