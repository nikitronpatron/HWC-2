// На ввод: любое число
// На вывод: третья цифра либо предупреждение, что ее нет

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberAbs = Convert.ToInt32(Math.Abs(number));


if(numberAbs > 99)
{
    while(numberAbs > 999)
    {
        numberAbs = numberAbs / 10;
    }
    int thirdNum = numberAbs % 10;
    Console.WriteLine(thirdNum);
    
}
else
{
    Console.WriteLine("There is no third digit");
}