//Показать таблицу квадратов чисел от 1 до N
Console.WriteLine("Insert ur number");
int number = int.Parse(Console.ReadLine());
for(int i = 1; i <= number; i++)
{
    for(int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}