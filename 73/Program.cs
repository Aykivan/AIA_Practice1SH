// Найти сумму элементов от M до N, N и M заданы

int Sum(int m,int n)
{
    if (m==n) return m;
    else return Sum(m+1,n)+m;
}
System.Console.WriteLine(Sum(1,3));