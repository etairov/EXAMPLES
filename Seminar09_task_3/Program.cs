/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
//------------------------

int SumOfDigits(int number, int sum)
{
    if (number > 0)
    {
        sum += number % 10;
        number /= 10;
        return SumOfDigits(number, sum);
    }
    else
        return sum;
}
int sum = SumOfDigits(5, 9);
Console.WriteLine(sum);

//-----------------------------

int SumOfDigits(int number, int sum)
{
if (number > 0)
{
sum += number % 10;
number /= 10;
return SumOfDigits(number, sum);
}
else
return sum;
}
Console.WriteLine (SumOfDigits(5, 8));
