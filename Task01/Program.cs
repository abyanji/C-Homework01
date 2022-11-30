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