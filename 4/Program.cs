// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Привет, введи число:");
int x = int.Parse(Console.ReadLine());
int a1 = x /10;
int a2 = a1 % 10;
Console.Write(a2);