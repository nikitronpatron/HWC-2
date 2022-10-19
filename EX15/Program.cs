// На ввод: цифра, обозначающая день недели
// На вывод: является ли этот день недели выходным (да/нет)

Console.WriteLine("Enter a number from 1 to 7: ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        Console.WriteLine("no");
        break;
    case 2:
        Console.WriteLine("no");
        break;
    case 3:
        Console.WriteLine("no");
        break;
    case 4:
        Console.WriteLine("no");
        break;
    case 5:
        Console.WriteLine("no");
        break;
    case 6:
        Console.WriteLine("yes");
        break;
    case 7:
        Console.WriteLine("yes");
        break;
    default:
        Console.WriteLine("Error");
        break;
}