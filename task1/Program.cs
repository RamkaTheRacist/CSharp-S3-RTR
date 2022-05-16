//Показать таблицу квадратов чисел от 1 до N
Console.WriteLine("Insert ur number");
int number = int.Parse(Console.ReadLine());
Console.Clear();
int tmp = 1;
while(tmp <= number)
{
    Console.WriteLine(tmp * tmp); tmp++;
}