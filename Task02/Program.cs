// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Введите три числа");
int[] numbers = new int[3];
numbers[0] = int.Parse(Console.ReadLine());
numbers[1] = int.Parse(Console.ReadLine());
numbers[2] = int.Parse(Console.ReadLine());
int max = numbers[0];
int index = 0;

while (index < numbers.Length)
{
    if (max < numbers[index])
    {
        max = numbers[index];
    }
    index++;
    
}
Console.WriteLine($"Максимальное число = {max}");