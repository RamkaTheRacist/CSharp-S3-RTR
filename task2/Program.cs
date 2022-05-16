//Найти сумму чисел от 1 до А
Console.WriteLine("Insert ur number");
int number = int.Parse(Console.ReadLine());
Console.Clear();
int tmp = 1;
int res = 0;
while(tmp <= number)
{
    res = res + tmp;
    Console.WriteLine(res);
    tmp++;
}