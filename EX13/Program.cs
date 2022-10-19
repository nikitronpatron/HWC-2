// На ввод: любое число
// На вывод: третья цифра либо предупреждение, что ее нет

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99)
{
    while(number > 1000)
    {
        number = number / 10;
    }
    int thirdNum = number % 10;
    Console.WriteLine(thirdNum);
}
else
{
    Console.WriteLine("There is no third digit");
}