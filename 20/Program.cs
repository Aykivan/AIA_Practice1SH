// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// На сколько я понял: 1 четверть (x, y), 2 четверть (-x,y), 3 четверть  (-x,-y), 4 четверть (x,-y)  

System.Console.Write("Введите координату x: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0) System.Console.WriteLine($"Точка находится в I четверти.");
if (x<0 && y>0) System.Console.WriteLine($"Точка находится в II четверти.");
if (x<0 && y<0) System.Console.WriteLine($"Точка находится в III четверти.");
if (x>0 && y<0) System.Console.WriteLine($"Точка находится в IV четверти.");