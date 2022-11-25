// С клавиатуры вводятся число вывести день недели

System.Console.WriteLine("введите число: ");
int day = Convert.ToInt32(Console.ReadLine());

//можно стандартным вариантом через if, однако switch - оптимальнее

switch (day)
{
    case 1:
        System.Console.WriteLine("Понедельник");
        break;
    case 2:
        System.Console.WriteLine("Вторник");
        break;
    case 3:
        System.Console.WriteLine("Среда");
        break;
    default:
        System.Console.WriteLine("нет подходящего значения");
        break;
}