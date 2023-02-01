//Задача 39: Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]
//--------------------------------
//Мое решение

int[] GetArray(int newstring)
{
    int[] arr = new int[newstring];
    Random rnd = new Random();

    for (int i = 0; i < newstring; i++)
    {
        arr[i] = rnd.Next(-10, 10);
    }
    return arr;
}

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - (i + 1)];
        array[array.Length - (i + 1)] = temp;
    }
    Console.Write("Массив чисел на входе: [");
    Console.Write(string.Join(", ", array));
    Console.Write("]");
}

int[] array = GetArray(5);

Console.Write("Массив чисел на входе: ["); //- лучше печать каждого массива выводить через отдельную функцию
Console.Write(string.Join(", ", array));
Console.Write("]");

Console.WriteLine();
Console.WriteLine($"-------------------------------------------------------------------------------");

ReverseArray(array);
//---------------------------------
//Решение преподавателя
/*
int[] InitArray(int dimension)
{
    int[] result = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        result[i] = rnd.Next(1, 10);
    }

    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] ReverseArray(int[] array)
{
    int[] result = new int[array.Length];
    int count = 0;

    for (int i = array.Length - 1; i >= 0; i--)
    {
        result[count] = array[i];
        count++;
    }

    return result;
}
int[] startArray = InitArray(10);
PrintArray(startArray);

int[] resultArray = ReverseArray(startArray);
PrintArray(resultArray);

int[] arrStart = Enumerable.Range(1, 10).ToArray();
PrintArray(arrStart);

int[] arr = Enumerable.Range(1, 10).Reverse().ToArray();
PrintArray(arr);
//--------------------------------
//Array.Reverse(arr);- переворот массивов
//arr.Reverse();

*/