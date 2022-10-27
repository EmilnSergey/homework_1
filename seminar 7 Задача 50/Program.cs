// Задача 50. Напишите программу, которая на вход принимает число и возвращает индексы элемента 
// в двумерном массиве или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void SearchNumber(int [,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == number)
            {
                Console.WriteLine($"Число найдено на строке {i + 1} в столбце {j + 1}");
            }
        }
    }
    return;
    Console.WriteLine("Число не найдено");
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t"); 
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int m, int n, int maxValue)
{
    int[,] result = new int[m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, maxValue +1);
        }
    }
    return result;
}

Console.Clear();
Console.Write("Введите количество строк в массиве:");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве:");
int colums = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row,colums, 10);
PrintArray(array);
Console.Write("Введите искомый элемент в массиве:");
int num = int.Parse(Console.ReadLine()!);
SearchNumber(array, num);
