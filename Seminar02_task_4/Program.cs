//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет
//----------------------------------

int GetNumber()
{ 
    Console.WriteLine("Введите любое число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int firstNumber = GetNumber();
int secondNumber = GetNumber();

if(firstNumber * firstNumber == secondNumber || secondNumber * secondNumber == firstNumber)
{
    Console.WriteLine("Да");
}
else
{
     Console.WriteLine("Нет");
}

