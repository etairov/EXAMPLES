//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10
//------------------ 
/*
int[] GetArray(int newstring)
{
    int[] arr = new int[newstring];
    Random rnd = new Random();

    for (int i = 0; i < newstring; i++)
    {
        arr[i] = rnd.Next(1, 10);
    }
    return arr;
}

void TranslateNum(int[] array)
{
   int num10 = 6; // число в десятичной системе исчисления
        int a = 0; // a - остаток после % деления из которого формируется число в 
                     //    двоичной системе исчисления
        int i = 0;
 
        int[] b = new int[]; // массив с помощью которого двоичное число позже 
                                 //будет выведено с конца для правильного отображения 
 
        while (num10 >= 1)
        {
            a = num10 % 2;
            b[i] = a;
            i++;
 
            num10 = num10 / 2;
 
            Console.Write(a);
        };
 
        Console.WriteLine();
 
        for (i = (b.Length - 1); i >= 0; i--)
        {
            Console.Write(b[i]);
        }
 
    Console.Write("Массив двоичных чисел: [");
    Console.Write(string.Join(", ", div));
    Console.Write("]");

}


int[] array = GetArray(5);

Console.Write("Массив десятичных чисел: [");
Console.Write(string.Join(", ", array));
Console.Write("]");

Console.WriteLine();
Console.WriteLine($"-------------------------------------------------------------------------------");

TranslateNum(array);
*/

//----------------------------------------------------------------
//Решение группы

/*
int number = Convert.ToInt32(Console.ReadLine());

int[] binar = new int[5];
    int div = 0;

    for (int i = 0; i < array.Length; i++)
    {
        while (div > 0)
        {
            div = div + array[i] % 2;
            binar[i] = div;

            div = div /2;
        }
    }
    Console.Write("Массив двоичных чисел: [");
    Console.Write(string.Join(", ", div));
    Console.Write("]");


string number_str = "";

while (number > 0)
{
    number_str = number_str + number % 2;
    number = number / 2;
}
string result = new string(number_str.Reverse().ToArray());
Console.WriteLine(result);
*/

 int num10 = 6; // число в десятичной системе исчисления
        int a = 0; // a - остаток после % деления из которого формируется число в 
                     //    двоичной системе исчисления
        int i = 0;
 
        int[] b = new int[10]; // массив с помощью которого двоичное число позже 
                                 //будет выведено с конца для правильного отображения 
 
        while (num10 >= 1)
        {
            a = num10 % 2;
            b[i] = a;
            i++;
 
            num10 = num10 / 2;
 
            Console.Write(a);
        };
 
        Console.WriteLine();
 
        for (i = (b.Length - 1); i >= 0; i--)
        {
            Console.Write(b[i]);
        }
 
        //Console.ReadKey();
 
    
 
