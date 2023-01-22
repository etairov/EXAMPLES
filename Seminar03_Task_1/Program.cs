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

//------------------------------------------------------------------------
//Решение преподавателя с функциями

int GetNumber(string message)
{
int resultNumber = 0;

while(true)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out resultNumber) && resultNumber != 0)
{
break;
}
else
{
Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!\n");
}
}

return resultNumber;
}

int GetQuarter(int x, int y)
{
if(x > 0 && y > 0)
return 1;
else if(x < 0 && y > 0)
return 2;
else if(x < 0 && y < 0)
return 3;
else
return 4;
}

int x = GetNumber("Введите координату Х, которая не равна 0:");
int y = GetNumber("Введите координату Y, которая не равна 0:");
int quarter = GetQuarter(x,y);

Console.WriteLine($"Точка с координатами ({x},{y}) лежит в {quarter} четверти");