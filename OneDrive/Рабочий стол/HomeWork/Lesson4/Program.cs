/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число B: ");

int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
    step = step * a;
}
Console.WriteLine("A возведенное в степень B равно: " + step);
*/
/*
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
    int num = i % 10;
    i = i / 10;
    sum = sum + num;
}

Console.WriteLine("Сумма цифр в числе: " + sum);
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

    
Console.Write("Введите массив: ");
string? seriesOfNumbers = Console.ReadLine();

int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
{
    numbers [i] = new Random().Next(0, 35);
    Console.Write(" " + Method (i) + " ");
}
Console.Write("]");

int Method (int a)
{
    return numbers[a];
}
