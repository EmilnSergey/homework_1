// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray (int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}

int Newarray (int [] array)

{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            even++;
        }
    }
    return even;
}

Console.WriteLine("Введите длину массива:");
int a = int.Parse(Console.ReadLine()!);
int[] array = GetArray(a);
Console.WriteLine(string.Join(",", array));
Console.Write($"Количество четных чисел равно {Newarray(array)}");