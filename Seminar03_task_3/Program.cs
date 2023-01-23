//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21
//----------------------------------

Console.WriteLine("Введите координату X точки A");
string AxStr = Console.ReadLine();
int Ax = Convert.ToInt32(AxStr);

Console.WriteLine("Введите координату Y точки A");
string AyStr = Console.ReadLine();
int Ay = Convert.ToInt32(AyStr);

Console.WriteLine("Введите координату X точки B");
string BxStr = Console.ReadLine();
int Bx = Convert.ToInt32(BxStr);

Console.WriteLine("Введите координату Y точки B");
string ByStr = Console.ReadLine();
int By = Convert.ToInt32(ByStr);

double resX = Math.Pow((Bx - Ax), 2);
double resY = Math.Pow((By - Ay), 2);
double distanceAB = Math.Sqrt(resX + resY);

Console.WriteLine($"Расстояние между точками на плоскости = {distanceAB:f2}");
//---------------------------------------------------------------------------
//Решение группы





//AB = √(Bx - Ax)2 + (By - Ay)2