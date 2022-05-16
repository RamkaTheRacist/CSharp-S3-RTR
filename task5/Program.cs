//Задать массив из 8 элементов и вывести их на экран
Console.WriteLine("Write ur own numbers for array");
void FillArray(int[] collection) // any name
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = Convert.ToInt32(Console.ReadLine());

        index++;
    }
}

int[] array = new int[8];
FillArray(array);
int index = 0;
int size = array.Length;
while(index < size)
{
Console.Write(array[index]);
index++;
}