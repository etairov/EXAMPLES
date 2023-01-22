//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
//-------------------------------------------
/*int quater = new Random().Next(1, 5);

int[] numberXplus = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] numberYplus = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] numberXmin = { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 };
int[] numberYmin = { -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 };

if (quater == 1)
{
    Console.Write("Диапазон X = ");
    for (int i = 0; i < numberXplus.Length; i++)
    {
        Console.Write(numberXplus[i]);
        Console.Write(", ");
    }

    Console.Write("Диапазон Y = ");
    for (int i = 0; i < numberYplus.Length; i++)
    {
        Console.Write(numberYplus[i]);
        Console.Write(", ");
    }
    Console.WriteLine($"Номер четверти {quater}");
}

else if (quater == 2)
{
    Console.Write("Диапазон X = ");
    for (int i = 0; i < numberXmin.Length; i++)
    {
        Console.Write(numberXmin[i]);
        Console.Write(", ");
    }

    Console.Write("Диапазон Y = ");
    for (int i = 0; i < numberYplus.Length; i++)
    {
        Console.Write(numberYplus[i]);
        Console.Write(", ");
    }
    Console.WriteLine($"Номер четверти {quater}");
}

else if (quater == 3)
{
    Console.Write("Диапазон X = ");
    for (int i = 0; i < numberXmin.Length; i++)
    {
        Console.Write(numberXmin[i]);
        Console.Write(", ");
    }

    Console.Write("Диапазон Y = ");
    for (int i = 0; i < numberYmin.Length; i++)
    {
        Console.Write(numberYmin[i]);
        Console.Write(", ");
    }
    Console.WriteLine($"Номер четверти {quater}");
}

else if (quater == 4)
{
    Console.Write("Диапазон X = ");
    for (int i = 0; i < numberXplus.Length; i++)
    {
        Console.Write(numberXplus[i]);
        Console.Write(", ");
    }

    Console.Write("Диапазон Y = ");
    for (int i = 0; i < numberYmin.Length; i++)
    {
        Console.Write(numberYmin[i]);
        Console.Write(", ");
    }
    Console.WriteLine($"Номер четверти {quater}");
}
//-------------------------------------------------------------------------------------------------------
//Нормальное решение через функции
//----------------------------------------*/
int GetQuarterNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out resul) && result > 0 && result < 5)
        {
            if (result != 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Вы не можете использовать ноль в этой программе");
            }
        }
        else
            {
                Console.WriteLine("Вы ввели некорректный номер");
            }
        }
        return result;
    }

    int quater = new Random().Next(1, 5);

    if (quater == 1)
    {
        Console.Write("X = {0, + бесконечность}, Y = {0, + бесконечность} ");
    }
    else if (quater == 2)
    {
        Console.Write("X = {0, - бесконечность}, Y = {0, + бесконечность} ");
    }
    else if (quater == 3)
    {
        Console.Write("X = {0, - бесконечность}, Y = {0, - бесконечность} ");
    }
    if (quater == 4)
    {
        Console.Write("X = {0, + бесконечность}, Y = {0, - бесконечность} ");
    }