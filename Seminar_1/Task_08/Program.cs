// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите натуральное число ");
int N = int.Parse(Console.ReadLine());
int index = -N;
while (index < N)
{
    if (index % 2 == 0)
    {
        Console.Write($"{index}, ");
    }
    index++;
}