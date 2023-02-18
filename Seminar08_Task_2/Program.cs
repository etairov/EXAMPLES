//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.
//----------------------------------------------------------------------------------

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод.");
        }
    }

    return result;
}
int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}

int countOfRows = GetNumber("Введите кол-во строк:");
int countOfColumns = GetNumber("Введите кол-во столбцов:");
int[,] matrix = InitMatrix(countOfRows, countOfColumns);

PrintMatrix(matrix);
//Transponente(matrix);

Console.WriteLine();
//PrintMatrix(matrix);

//---------------------------------
//Для квадратных матриц
/*
void Transponente(int[,] matrix)
{

    var iMax = matrix.GetLength(0);
    var jMax = matrix.GetLength(1);

    for (int i = 1; i < iMax; i++)
    {
        for (int j = 0; j < i; j++)
        {
            var a = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = a;
        }
    }
}
*/
//---------------------------------------------------
//Решение в группе для любых матриц

int[,] TransporationMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[j, i] = matrix[i, j];
        }
    }
    return newMatrix;
}

int[,] finalMatrix = TransporationMatrix(matrix);
PrintMatrix(finalMatrix);
