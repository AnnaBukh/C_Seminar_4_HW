// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
// взяла числа в диапазоне от 1 до 100 

int [] CreateArray()
{
    int [] array  = new int[8];
    for (int i =0; i <= 7; i++)
    {
        array[i] = new Random().Next(0, 101);
    }
    return array;
}

int[] array = CreateArray();

void PrintArray()
{
Console.Write("Массив из 8 элементов: [");    
for (int i = 0; i <= 7; i++)
 {
    if (i <= 6) Console.Write($"{array [i]}, ");
    else Console.Write($"{array [i]}");
 }
Console.Write("]");  
}

PrintArray();