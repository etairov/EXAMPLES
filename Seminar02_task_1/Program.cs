//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98
//----------------------------------
/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/
int GetRandomValue()
{
    return new Random().Next(100, 1000);
}

int DeleteSecondNumber(int number)
{
    return (number / 100) * 10 + (number % 10);
}

int number = GetRandomValue();
int result = DeleteSecondNumber(number);
Console.WriteLine($"Было {number}, стало {result}.");

//_________________________________________
//Пример преподавателя

/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа.

Например:
78 -> 8
12-> 2
85 -> 8

*/

/*
1. метод, который получает случайное число
2. метод, который получает максимальную цифру числа
*/

//метод, который получает случайное число
//int GetRandomNumber(int leftBound, int rightBound)
//{
//    int result = 0;
//    Random rnd = new Random();

//    result = rnd.Next(leftBound, rightBound + 1);// [leftBoung, rightBound)
//    return result;
//}

//метод, который получает максимальную цифру числа
//int GetMaxDigitOfNumber(int number)
//{
//    int firstDigit = number / 10;// 96 / 10 = 9,6
//    int secondDigit = number % 10;
//
//    if(firstDigit > secondDigit)
//        return firstDigit;
//    else
//        return secondDigit;
//}

//int number = GetRandomNumber(10, 99);
//int maxDigit = GetMaxDigitOfNumber(number);

//Console.WriteLine($"Максимальная цифра числа {number} = {maxDigit}");
