﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int i = 2;

if (N>1)
{
    while (i < N+1)
    {
        Console.WriteLine(i);
        i = i+2;
    }
}
else
{
    Console.WriteLine("Четных положительных чисел нет");
}