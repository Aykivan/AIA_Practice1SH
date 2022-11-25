int[] a = new int[10];

int[] RandomIntArray(int size, int min, int max) // Заполнение массива случайными числами
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
        a[i] = random.Next(min, max);
    return a;
}

void Print(int[] a) // Вывод массива 
{
    for (int i = 0; i < a.Length; i++)
        System.Console.Write($"{a[i],5}");
}

// Подпрограмма поиска линейного значения
int LinearSearch(int[] m, int find) // Добавить массив и искомое значение
{
    int i = 0;
    while (i < m.Length && m[i] != find) i++;
    if (i == m.Length) return -1; // Ели элемент не найден, то выводим значение за пределами массива
    else return i; // Если найден, выводи i
}

/* Линейный поиск массива
int[] m = RandomIntArray(10, 0, 100);
int i = 0; // Переменная - счетчик
int find = 20; // Задали искомое значение
m[4] = find; // Прировняли элемент массива с индексом 4 к искомому значению 
Print(m); // Выводим получившийся массив 
System.Console.WriteLine();
while (i < m.Length && m[i] != find) i++; // Цикл поиска соотвесвующего значения 
if (i == m.Length) System.Console.WriteLine($"Element {find} not found"); // Вывод результатов поиска
else System.Console.WriteLine($"Element {find} at {i}");*/

int[] m = RandomIntArray(10, 0, 100); 
int find = 20;  
Print(m); 
System.Console.WriteLine();
int i = LinearSearch(m,find); // Сохранили результаты поиска в переменную i
if (i==-1) System.Console.WriteLine($"Element {find} not found"); 
else System.Console.WriteLine($"Element {find} at {i}");