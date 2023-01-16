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