/*  Метод для нахождения double числа в диапазоне от -1 до 1 включительно
----------------------------------------------------------
Console.WriteLine("Hello, World!");

public double GetRandomNumber(double minimum, double maximum)
{
Random random = new Random();
return random.NextDouble() * (maximum - minimum) + minimum;
}
-----------------------------------------------------------*/

//Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]
//---------------------------------------------

int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    Console.Write(string.Join(",", arr));
    Console.Write("] -->");
}

void ReverseNumber(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0 || array[i] < 0)
            array[i] = array[i] * (-1);
    }
    Console.Write(string.Join(",", array));
    Console.Write($"]");
}

int[] array = InitArray(10);
PrintArray(array);
ReverseNumber(array);

//------------------------------------------
//Решение группы

int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

void ConvertArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
}

int[] array = InitArray(4);
Console.WriteLine(string.Join(",", array));

ConvertArray(array);
Console.WriteLine(string.Join(",", array));


