//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10
//------------------ 

int[] GetArray(int newstring)
{
    int[] arr = new int[newstring];
    Random rnd = new Random();

    for (int i = 0; i < newstring; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
    return arr;
}

void TranslateNum(int[] array)
{
    Console.Write("Массив двоичных чисел: [");
    int N = array.Length;

    for (int i = 0; i < N; i++)
    {
        int number = array[i];
        string number_str = "";

        while (number > 0)
        {
            number_str = number_str + number % 2;
            number = number / 2;
        }
        
        string result = new string(number_str.Reverse().ToArray());

        if (i < (N - 1))
            Console.Write($"{result}, ");
        else
            Console.Write($"{result}");
    }
    Console.Write("]");
}

int[] array = GetArray(10);

Console.Write("Массив десятичных чисел: [");
Console.Write(string.Join(", ", array));
Console.Write("]");

Console.WriteLine();
Console.WriteLine($"-------------------------------------------------------------------------------");

TranslateNum(array);
