// Выяснить являются ли три числа сторонами треугольника
 
bool CheckTriangle(double a, double b, double c)
{
    return a+b>c && a+c>b && b+c>a;
}

double a=5;
double b=8;
double c=4;

if (CheckTriangle(a,b,c)) System.Console.WriteLine("YES"); 
else System.Console.WriteLine("NO");