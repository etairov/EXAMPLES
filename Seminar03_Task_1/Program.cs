//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
//-------------------------------------------------------------------------------------

    int numberX = new Random().Next(-10, 10);
    int numberY = new Random().Next(-10, 10);

    if (numberX >= 1 & numberY >= 1)
    {
        Console.WriteLine($"X = {numberX}, Y = {numberY}  --> I Четверть");
    }
    else if (numberX <= -1 & numberY >= 1)
    {
        Console.WriteLine($"X = {numberX}, Y = {numberY}  --> II Четверть");
    }
    else if (numberX <= -1 & numberY <= -1)
    {
        Console.WriteLine($"X = {numberX}, Y = {numberY}  --> III Четверть");
    }
    else if (numberX >= 1 & numberY <= -1)
    {
        Console.WriteLine($"X = {numberX}, Y = {numberY}  --> IV Четверть");
    }
    if (numberX == 0 || numberY == 0)
    {
        Console.WriteLine("Нулевые координаты");
    }

Console.WriteLine($"Ввод Рандом Х= {numberX}, Ввод Рандом Y = {numberY}");