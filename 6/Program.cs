//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Привет, введи число:");
int x = int.Parse(Console.ReadLine());
if (x <= 5)
    {
        Console.WriteLine("Нет");
    }
else if (x <= 7)
    {
        Console.WriteLine("Да");
    }
else 
    {
        Console.WriteLine("Некорректное число");
    }
