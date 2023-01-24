//1. Задача со строками.
//Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы “к” заменить большими “К”, а большие “С” заменить
//маленькими “с”.
//Ясна ли задача?
//-------------------------------------------------------------------------
string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
              + "ежели бы вас послали вместо нашего милого Винценгероде, "
              + "вы бы взяли приступом согласие прусского короля. "
              + "Вы так красноречивы. Вы дадите мне чаю? ";
//-------------------------------------------------------------------------

// string s = {qwerty}
//             0123          
// s[3] = r

string replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newtext = replace(text, ' ', '/');
Console.WriteLine(newtext);

Console.WriteLine();

newtext = replace(newtext, 'к', 'К');
Console.WriteLine(newtext);

Console.WriteLine();

newtext = replace(newtext, 'о', 'О');
Console.WriteLine(newtext);

Console.WriteLine();
//---------------------------------------

// 2. Задача с массивами чисел. Сортировка.

int[] arr = { 1, 2, 3, 4, 5, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;

        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);