// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.Задача 2
Console.Clear();
Console.Write("Введите первое число:");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int y = int.Parse(Console.ReadLine());
if(y < x)
    {
        Console.WriteLine(x);
    }
else 
    {
        Console.WriteLine(y);
    }