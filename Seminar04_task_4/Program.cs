//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
//------------------------------

int[] GetArray()
{
    int[] array = new int[8];
    Random rand = new Random();

    for (int y = 0; y < 8; y++)
    {
        array[y] = rand.Next(0, 2);
        Console.Write(array[y] + " ");
    }
    return array;
}
GetArray();
//---------------------------------------
// Выполнение в группе

int[] CreateArray()
{
    int[] Array = new int[8];
    Random number = new Random();
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = number.Next(0, 2);
    }
    return Array;
}
int[] a = CreateArray();

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
}
PrintArray(a);