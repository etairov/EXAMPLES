//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8
//-------------------------------

//------------------------------------------
//Решение группы

int[] Fibonachi(int number)
{
    int[] arr = new int[number];
    if (number == 1)
        return new int[1] { 0 };
    if (number == 2)
        return new int[2] { 0, 1 };
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < number; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

Console.WriteLine("Введите количество чисел: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = Fibonachi(number);
Console.WriteLine(string.Join(", ", array));

