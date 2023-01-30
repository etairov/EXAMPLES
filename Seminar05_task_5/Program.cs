//Задача 37: Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21
//------------------------------

int[] GetArray(int newstring)
{
    int[] arr = new int[newstring];
    Random rnd = new Random();

    for (int i = 0; i < newstring; i++)
    {
        arr[i] = rnd.Next(0, 10);
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
int[] Multiply(int[] arr)
{
    bool chetniy = true;
    int[] newArr = null;
    if (arr.Length % 2 == 0)
        newArr = new int[arr.Length / 2];
    else
    {
        newArr = new int[arr.Length / 2 + 1];
        chetniy = false;
    }
    for (int i = 0; i < newArr.Length; i++)
    {
        if (!chetniy && i == newArr.Length - 1)
            newArr[i] = arr[i];
        else
            newArr[i] = arr[i] * arr[arr.Length - i - 1];
    }
    return newArr;
}
//-------------------------------------------------------

int[] array = GetArray(11);
PrintArray(array);

Console.WriteLine();
Console.WriteLine($"-------------------------------------------------------------------------------");

int[] newArray = Multiply(array);
Console.Write("Массив произведений: [");
Console.Write(string.Join(", ", newArray));
Console.Write("]");

/*---------------------------------------------- 
//Решение в группе

int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(0, 10);
    }
    return arr;
}

int[] MultiOfNumbers(int[] arr)
{
    bool chetniy = true;
    int[] newArr = null;
    if (arr.Length % 2 == 0)
        newArr = new int[arr.Length / 2];
    else
    {
        newArr = new int[arr.Length / 2 + 1];
        chetniy = false;
    }
    for (int i = 0; i < newArr.Length; i++)
    {
        if (!chetniy && i == newArr.Length - 1)
            newArr[i] = arr[i];
        else
            newArr[i] = arr[i] * arr[arr.Length - i - 1];
    }
    return newArr;
}

int[] arrayF = InitArray(10);
Console.WriteLine(string.Join(", ", arrayF));
int[] newArrayF = MultiOfNumbers(arrayF);
Console.WriteLine(string.Join(", ", newArrayF));

*/