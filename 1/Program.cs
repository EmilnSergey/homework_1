// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.Задача 4
Console.Clear();
Console.Write("Введите первое число:");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите второе число:");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите третье число:");
int z = int.Parse(Console.ReadLine());
int max = x;
if(max < y) 
    {
        max = y;
    }

if (z > max)
    {
        max = z;
    }

Console.Write(max);
