// Задача на нахождение индекса элемента массива

int[] array = {1, 3, 15, 6, 8, 3, 4};
int n = array.Length;
int find = 3;
int index = 0; 

while (index < n)
{
    if (array[index] == find)
    {
    Console.WriteLine(index);
    break;       
    }    
    index++;
}