// На ввод: трехзначное число
// На вывод: вторую цифру числа

Console.WriteLine("Enter three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberAbs = Convert.ToInt32(Math.Abs(number));


if (numberAbs > 99 && numberAbs < 1000)
{
    int ten = numberAbs / 10;
    int hundred = numberAbs / 100;
    int result = ten - hundred * 10;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(result);
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Error");
    Console.ResetColor();
}