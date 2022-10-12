﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.Write("Введите Х координаты A: ");
int x1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты A: ");
int y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z координаты A: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Х координаты B: ");
int x2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты B: ");
int y2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z координаты A: ");
int z2 = int.Parse(Console.ReadLine()!);

double result;
result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1,2));
result = Math.Round(result,2);
Console.Write($"Длина отрезка AB равна {result}");
