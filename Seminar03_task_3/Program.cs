//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21
//Формула нахождения расстояния между точками AB = √(Bx - Ax)2 + (By - Ay)2
//----------------------------------

/*Console.WriteLine("Введите координату X точки A");
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

Console.WriteLine($"Расстояние между точками на плоскости = {distanceAB:f2}");*/
//---------------------------------------------------------------------------
//Решение группы

int getCoordFromUser(string message){
    int result = 0;
    while (true){
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result)){
                break;
        }        
        else{
            Console.WriteLine("You've entered incorrect number");
        }
    }
    return result;
}

double getDistance(int ax, int ay, int bx, int by){
    double result = Math.Sqrt(Math.Pow(ax-bx,2) + Math.Pow(ay-by, 2));
    return result;
}

int ax = getCoordFromUser("Enter x coordinate of the first point");
int ay = getCoordFromUser("Enter y coordinate of the first point");


int bx = getCoordFromUser("Enter x coordinate of the second point");
int by = getCoordFromUser("Enter y coordinate of the second point");

double distance = getDistance(ax, ay, bx, by);

Console.WriteLine($"Distance between({ax},{ay}) and ({bx},{by}) is {distance:f3}");





