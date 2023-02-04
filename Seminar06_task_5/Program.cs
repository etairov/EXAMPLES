//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
//------------------------------------

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

int[] CopyArray(int[] startArr)
{
    int[] arr = new int[startArr.Length];
    for (int i = 0; i < startArr.Length; i++)
    {
        arr[i] = startArr[i];
    }
    return arr;
}

int dimension = 5;
int[] startArr = InitArray(dimension);
Console.WriteLine("[{0}]", string.Join(", ", startArr));
int[] arr = CopyArray(startArr);
Console.WriteLine("[{0}]", string.Join(", ", arr));

//Console.WriteLine("[{0}]", string.Join(", ", array))- формат вывода массива со скобками и запятыми