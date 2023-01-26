//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5
//----------------------
// Мой вариант

int GetNumber()
{
    Console.WriteLine("Введите любое число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int resultGetNumber = GetNumber();

int N = resultGetNumber;
int i = 0;
while (N > 0 || N < 0)
{
    i++;
    N /= 10;
}
Console.Write($"Количество знаков в числе {resultGetNumber} -> {i}");

//-------------------------------
// Вариант из другого источника / 

Console.Write("Введите число : ");

int num = int.Parse(Console.ReadLine());
int i = 0;
while (num > 0)
{
    i++;
    num /= 10;
}
Console.WriteLine($"Количество цифр введенного числа : {i}");

//----------------------------------
//Вариант группы

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }

    return Math.Abs(result);
}

void GetLong(int GetNumber)
{
    string GetText = GetNumber.ToString();
    int longText = GetText.Length;
    Console.WriteLine(longText);
}

int number = GetNumber("Введите любое число");
GetLong(number);

