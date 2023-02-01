//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон
//----------------------------------------------------------

int[] GetArray(int newstring)
{
    int[] arr = new int[newstring];
    Random rnd = new Random();

    for (int i = 0; i < newstring; i++)
    {
        arr[i] = rnd.Next(0, 50);
    }
    return arr;
}

void CheckTriangle(int[] array)
{
    int ab = array[0];
    int bc = array[1];
    int ac = array[2];

    if (ab < (bc + ac) && bc < (ab + ac) && ac < (ab +bc))
    {
        Console.WriteLine($"Треугольник с такими сторонами возможен");
    }
    else
    {
        Console.WriteLine($"Такой фигуры нет");
    } 
}

int[] array = GetArray(3);

Console.Write("Длины сторон: [");
Console.Write(string.Join(", ", array));
Console.Write("]");

Console.WriteLine();
Console.WriteLine($"-------------------------------------------------------------------------------");

CheckTriangle(array);

//---------------------------------------


