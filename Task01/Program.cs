// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Введите два числа");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

if (A > B)
{
    Console.WriteLine($"Max = {A}");
}
else
{
    Console.WriteLine($"Max = {B}");
}