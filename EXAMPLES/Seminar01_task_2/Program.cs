//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

//Вариант решения, приведенный одногруппниками:
//int c = a - b

//if(c == b)
//Console.WriteLine("Является квадратом")
//else
//Console.WriteLine("Не является квадратом")
//----------------------------------------------
//Форматирование строк (создание отступов)- команда Shift- Alt- F 

Console.WriteLine("Введите желаемый квадрат числа");
string number1Str = Console.ReadLine();

Console.WriteLine("Введите начальное число");
string number2Str = Console.ReadLine();

int number1 = Convert.ToInt32(number1Str);
int number2 = Convert.ToInt32(number2Str);

if (number2 * number2 == number1)
{
    Console.WriteLine($"Да, квадрат числа {number2} = {number1}");
}
else
{
    Console.WriteLine("Нет, не является квадратом");
    Console.WriteLine("Заданное число = " + number2 + " Заданный квадрат числа = " + number1);
    Console.WriteLine("Правильный результат = " + (number2 * number2));
}
