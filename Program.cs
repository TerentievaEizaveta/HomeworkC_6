// Домашняя работа
/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
ввёл пользователь.*/
Console.Clear();
void NumberOfPositive(int size)
{
    int count=0;
    int counter=0;
    while (counter<size)
    {
        Console.Write("Input number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num>0) count ++;
        counter++;
    }
    Console.WriteLine("Number of positive "+ count);
}

Console.Write("Input number of numbers: ");
int M = Convert.ToInt32(Console.ReadLine());
NumberOfPositive(M);

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.*/
