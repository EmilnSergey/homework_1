// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
Console.WriteLine("Введите массив чисел: ");
for (int i = 0; i < array.Length; i++)
{
array[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < array.Length; i++)
{
if (i == array.Length - 1)
{
Console.Write(array[i]);
} else {
Console.Write(array[i] + ",");
}
}