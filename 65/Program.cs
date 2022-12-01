// Написать подпрограмму, поиска элемента в двумерном массиве, подпрограмма возвращает позицию числа. 
// Если элемент отсутствует, подпрограмма возвращает -1.

int[,] RandomArray(int r, int c, int min = 0, int max = 9)
{
    int[,] a = new int[r, c];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
        for (int j = 0; j < a.GetLength(1); j++)
            a[i, j] = random.Next(min, max + 1);
    return a;
}

void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],4}");
        System.Console.WriteLine();
    }
}

bool Search(int[,] a, int find, out int i, out int j)
{
    for (i = 0; i < a.GetLength(0); i++)
        for (j = 0; j < a.GetLength(1); j++)
            if (a[i, j] == find) return true;
    j = -1;
    return false;
}

int row = 4;
int colum = 4;
int[,] array = RandomArray(row, colum);
PrintArray(array);

int find = 5;
int i, j;
if (Search(array, find, out i, out j)) System.Console.WriteLine($"Element {find} in position [{i},{j}]");
else System.Console.WriteLine($"Element {find} not found");