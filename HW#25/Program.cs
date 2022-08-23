// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную! степень B.
//натуральная степень   - произведение В раз числа А
//3, 5 -> 243 (3⁵) // вычисление : 3 * 3 * 3 * 3 * 3 = 243, число А умножаем на себя В раз  
//2, 4 -> 16 // вычисление : 2 * 2 * 2 * 2 = 16, число А умножаем на себя В раз 

Console.WriteLine("Введите число А: ");
int bases = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int index = Convert.ToInt32(Console.ReadLine());

int bases1 = bases;

int NumberOfPow(int bas, int ind)
{   
    int numOfPow = 1; 
    for (int i = 0; i < ind; i++)
    {
        numOfPow = numOfPow*bas;
    }
    //int i = 0;
    //while (i < index)
    //{
    //    numOfPow = numOfPow*bases;
    //    i = i + 1;
    //}
    return numOfPow;
}
int result = NumberOfPow(bases, index);
Console.WriteLine($"Число {bases} в степени {index} равно {result}");
