//Финальное упражнение Лекции №2
//--------------------------------

void FillArray(int[] collection)//Метод, заполняющий массив
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 10);
        index++;
    }
}

void PrintArray(int[] col)//Метод, печатающий массив
{
    int count = col.Length;
    int position = 0;//Аналог переменной index
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;//При int position = -1, при вводе числа, превышающего границы массива, программа выводит -1
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];//Создать новый массив с кол-вом эл-тов- 10
//Массив по умолчанию заполнен нулями, чтобы его заполнить числами, необходим метод выше.

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);