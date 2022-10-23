// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArray (int size)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        double num = new Random().NextDouble();
        res[i] = num * 10;
    }
    return res;
}

double GetSub (double [] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) {
            max = array[i];
        } 
        if (array[i] < min) {
            min = array[i];
        }
    }

    double sub = max - min;

    return sub;
}

Console.WriteLine("Введите длину массива:");
int a = int.Parse(Console.ReadLine()!);
double[] array = GetArray(a);
Console.WriteLine(string.Join(" ", array));
Console.Write($"Разница между максимальным и минимальным элементов массива равна {GetSub(array)}");