//Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Insert ur number");
int number = int.Parse(Console.ReadLine());
int tmp = 1;
int res = 1;
while(tmp <= number)
{
    res = res * tmp; tmp++;
}
Console.WriteLine($"Result is {res}");