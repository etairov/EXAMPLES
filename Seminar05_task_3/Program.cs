//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да
//--------------------------------------

int GetNumber()
{
    int number = new Random().Next(-10, 10);

    Console.Write($"{number}; ");
    return number;
}

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

void PrintArray(int[] arr)
{
    Console.Write("массив [");

    Console.Write(string.Join(", ", arr));
    Console.Write("]");

}

bool Revision(int[] arr, int num)
{
    bool result = false;

    for (int i = 0; i < arr.Length; i++)
    {
        if (num == arr[i])
        {
            result = true;
            break;
        }
    }
    return result;
}    

int num = GetNumber();
int[] array = GetArray(10);
PrintArray(array);
bool ai = Revision(array, num);

if(ai) Console.WriteLine($" -> Да, содержит");
else Console.WriteLine($" -> Нет, не содержит");


//--------------------------------
/*Решение в группе

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

bool FindNumber(int find, int[] arr)
{
    bool result = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (find == arr[i])
        {
            result = true;
            break;
        }
    }
    return result;
}

int[] arr = InitArray(10);
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine("Что будем искать? ");
int find = Convert.ToInt32(Console.ReadLine());
bool a = FindNumber(find, arr);

if (a) Console.WriteLine("Элемент найден");
else Console.WriteLine("Элемент не найден");

*/




