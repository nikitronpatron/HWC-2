// На ввод: трехзначное число
// На вывод: вторую цифру числа

Console.WriteLine("Enter three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int ten = number / 10;
    int hundred = number / 100;
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