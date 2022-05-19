//Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Insert ur number");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Exponentiation?");
int exp = int.Parse(Console.ReadLine());
int res = number;
if(exp > 0)
{
for(int i = 2; i <= exp; i++)
{
    res = res * number;
}
Console.WriteLine($"{number}^{exp} = {res}");
}
else if(exp == 0)
{
    Console.WriteLine($"{number}^{exp} = 0");
}
else
{
    Console.WriteLine("Exponentiation shouldnt be less than 0");
}