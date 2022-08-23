// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number; 
if (number < 0)
{
    number = -number;
}
int SumOfGigit(int num)
{   
    int sum = 0; 
    int i = 0;
    int digit = 0;
    while (i < num)
    {
        digit = number % 10;
        sum += digit;
        number /= 10;
        i = i + 1;
    }
    return sum;
}
int result = SumOfGigit(number);
Console.WriteLine($"сумма цифр в числе {number1} равна {result}");
