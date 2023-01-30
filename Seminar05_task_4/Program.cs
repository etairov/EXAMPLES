// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5
//-------------------------------

int[] GetArray(int newstring)
{
    int[] arr = new int[newstring];
    Random rnd = new Random();

    for (int i = 0; i < newstring; i++)
    {
        arr[i] = rnd.Next(0, 200);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("Массив чисел на входе: [");

    Console.Write(string.Join(", ", arr));
    Console.Write("]");

}
//----------------------------------------
void Revision(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
            count++;
    }
    Console.WriteLine($"Количество чисел в диапазоне от 10 до 99 --> {count}");
}
//-----------------------------------------   

int[] array = GetArray(123);
PrintArray(array);

Console.WriteLine();
Console.WriteLine($"-------------------------------------------------------------------------------");

Revision(array);

//--------------------------------------------
//Решение группы

int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(0, 1000);
    }
    return arr;
}

int FindCount(int[] arr)
{
    var count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] < 100)
            count++;
    }
    return count;
}

Console.WriteLine();

int[] arrayFind = InitArray(10);
int count = FindCount(arrayFind);

Console.WriteLine(string.Join(", ", arrayFind));

Console.WriteLine($"-> В указанном массиве находится {count} двухзначных чисел.");

