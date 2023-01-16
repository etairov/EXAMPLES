//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
//на само себя).

//Например:
//4 -> 16
//-3 -> 9
//-7 -> 49

int number = new Random().Next(0, 9);
int sqrt = number * number;
Console.Write("Число = ");
Console.WriteLine(number);
Console.Write("Квадрат числа = ");
Console.WriteLine(sqrt);

//Вариант со вводом числа с консоли.
//Console.Write("Введите число");
//string numberStr = Console.ReadLine(); //Консоль всегда воспринимает только строчные данные.
//int number = Convert.ToInt32(numberStr); //Конвертация в тип данных int.

//int result = number * number;

//Console.WriteLine($"Квадрат числа {number} = {result}"); //Так сейчас выводят рез-т в продакшн(через интерполяцию строк $)
//Console.WriteLine("Квадрат числа" + number + " = " + result); //Так делали до появления интерполяции
//Console.WriteLine("Квадрат числа {0} = {1}", number, result); //Один из вариантов