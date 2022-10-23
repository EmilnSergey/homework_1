// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях. 
// [3, 7, 23, 12] -> 19 
// [-4, -6, 89, 6] -> 0

int[] GetArray (int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(0, 1000);
    }
    return res;
}

int GetSum (int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }

    return sum;
}
Console.WriteLine("Введите длину массива:");
int a = int.Parse(Console.ReadLine()!);
int[] array = GetArray(a);
Console.WriteLine(string.Join(",", array));
Console.Write($"Сумма элементов на нечетных позициях равна {GetSum(array)}");
