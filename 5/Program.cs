// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
int num = new Random().Next(10,10000);
Console.WriteLine(num);
if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
else if (num >99 && num < 1000)
    {
        int x = num % 10;
        Console.WriteLine(x);
    }
else 
    { 
        int x = num % 100;
        int y = x /10;
        Console.WriteLine(y);
    }
