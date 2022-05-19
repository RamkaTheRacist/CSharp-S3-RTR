//Найти сумму чисел от 1 до А
Console.WriteLine("Insert ur number");
int number = int.Parse(Console.ReadLine());
int res = 0;
for(int i = 1; i <= number; i++)
{
    res = res + i;
}
Console.WriteLine($"Result is {res}");