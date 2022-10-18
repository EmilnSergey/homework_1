// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// 3, 5 -> 243 (3⁵) 2, 4 -> 16

Console.Write("Введите возводимое число:");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите степень числа:");
int b = int.Parse(Console.ReadLine());
int i = 0;
int pow = a;
while (i<b - 1)
{
pow = pow * a;
i = i + 1;
}
Console.Write(pow);

