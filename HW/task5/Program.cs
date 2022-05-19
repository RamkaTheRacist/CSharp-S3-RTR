//Подсчитать сумму цифр в числе
Console.WriteLine("Insert ur number");
int number = int.Parse(Console.ReadLine());
int sum = 0;
int digit = 0;
if(number > 0)
{
    while(number > 0)
    {
    digit= number % 10;
    sum = sum + digit;
    number = number / 10;
    Console.WriteLine($"Result is {sum}");
    }
}
else if(number == 0)
{
Console.WriteLine($"Result is {number}");
}
else
{
    while(number < 0)
    {
    digit= number % 10;
    sum = sum + digit;
    number = number / 10;
    Console.WriteLine($"Result is {sum}");
    }  
}