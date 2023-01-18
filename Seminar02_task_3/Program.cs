// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
//7 и 23.

//14 -> нет 
//46 -> нет 
//161 -> да
//------------------------------

int GetNumber()
{ Console.WriteLine("Введите любое число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int firstNumber = GetNumber();

if (firstNumber % 7 == 0 && firstNumber % 23 == 0)

{
    Console.WriteLine($"число кратно 7 и 23");
}
else
{
    Console.WriteLine($"число не кратно 7 и 23");
}