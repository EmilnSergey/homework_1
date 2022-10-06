// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Введите число:");
int x = int.Parse(Console.ReadLine());
int result = x % 2;
if (result == 0)
    {
      Console.WriteLine("четное");  
    }
else 
    {
      Console.WriteLine("нечетное");
    }