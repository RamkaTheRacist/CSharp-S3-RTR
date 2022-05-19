//Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Insert ur number");
int number = int.Parse(Console.ReadLine());
void check(int number)
{
    int tmp = number * number * number;
    int digit = tmp % 10;
    if(digit % 2 == 0)
    {
    Console.WriteLine($"{tmp}");
    return;
    }
    else
    {
    Console.WriteLine("Nope");    
    return;
    }
}
check(number);
