//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
//от 1 до N.

//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4
//------------------------------

Console.WriteLine("Введите число n");
string nStr = Console.ReadLine();
int n = Convert.ToInt32(nStr);
double quadra = n;
int count = 0;

Console.Write($"Квадраты чисел от 1 до {n} ---> ");

while (count <= n)
{
    quadra = Math.Pow(count, 2);
    if (count < n)
    {
        Console.Write(quadra + ", ");    
    }
    else
    {
        Console.Write(quadra + "  ");
    }
    count++;
}
//-----------------------------------------
//Решение группы

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());


for (int i = 1; i <= number; i++)
{
Console.Write($"{i*i},");
}