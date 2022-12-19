// Домашняя работа
/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
ввёл пользователь.*/
/*
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
*/
/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.*/
/*
void Point(int b1, int k1, int b2, int k2)
{
    double x =(double) (b2-b1)/(k1-k2);
    double y = (double)(k1*x+b1);
    if ( k1==k2) Console.WriteLine($"Lines are parallel.");
    else if ( (b1==b2)&& ( k1==k2) ) Console.WriteLine($"Lines will match.");
    else 
        Console.WriteLine($"Intersection lines y={k1}x+{b1} and y={k2}x+{b2} is a point ({x};{y}).");
}
Console.Write("Input b1 ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k1 ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2 ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2 ");
int k2 = Convert.ToInt32(Console.ReadLine());
Point(b1,k1,b2,k2);
*/