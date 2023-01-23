//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
//от 1 до N.

//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4
//------------------------------

Console.WriteLine("Введите число n");
string nStr = Console.ReadLine();
int n = Convert.ToInt32(nStr);

while (int count <= n)
{
    double quadra = Math.Pow(1, n);
}
count++;

Console.WriteLine($"Квадраты чисел от 1 до {n} -> {quadra}")