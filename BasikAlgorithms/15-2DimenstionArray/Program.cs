// Ввод-вывод двумерного массива, поиск в двумерном массиве
// Cортировка двумерного массива(по колонкам, так как в дз есть задание на сортировку по строкам).

int[,] RandomArray(int r, int c, int min = 0, int max = 9)
{
    int[,] a = new int[r, c];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = random.Next(min, max + 1);
        }
    }
    return a;
}

void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            System.Console.Write($"{a[i, j],3}");
        }
        System.Console.WriteLine();
    }
}

int row = 4;
int colums = 4;
int[,] array = new int[row, colums]; // 1 - Количество строк 2 - количество столбцов
// int[,] array1 = new int[3, 4] { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
// int[,] array2 = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
array = RandomArray(row, colums);
PrintArray(array);

// Поиск в массиве 

bool LinearSearch(int[,] a, int find, out int i, out int j)
{
    for (i = 0; i < a.GetLength(0); i++)
    {
        for (j = 0; j < a.GetLength(1); j++)
        {
            if (a[i, j] == find)
                return true;
        }
    }
    j = -1;
    return false;
}

int find = 7;
int i, j;
System.Console.WriteLine();
System.Console.WriteLine("Поиск елемента массива: ");
if (LinearSearch(array, find, out i, out j)) System.Console.WriteLine($"Element {find} in position [{i},{j}]");
else System.Console.WriteLine($"Element {find} not found");

// Сортировка массива

void SortArray(int[,] a)
{
    for (int j = 0; j < a.GetLength(1); j++)
       for (int k = 0; k < a.GetLength(1); k++) // Отвечает за количество раз, сколько элементов
            for (int i = 0; i < a.GetLength(0) - 1; i++) // Цикл поиска в одной колонне
                if (a[i, j] > a[i + 1, j])
                {
                    int t = a[i, j];
                    a[i, j] = a[i + 1, j];
                    a[i + 1, j] = t;
                }
}

System.Console.WriteLine();
System.Console.WriteLine("Сортировка массива по колоннам: ");
SortArray(array);
PrintArray(array);