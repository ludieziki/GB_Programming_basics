// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] array = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
void PrintArray(double[] x)
{
    Console.WriteLine();
    Console.Write($"[{x[0]}");
    for(int i = 1; i < x.Length; i++)
    {
        Console.Write($"; {x[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}
double[] MidRows = new double[array.GetLength(1)];
for (int i = 0; i < array.GetLength(1); i++)
{
    for (int j = 0; j < array.GetLength(0); j++) MidRows[i] = MidRows[i] + array[j, i];
    MidRows[i] = MidRows[i] / array.GetLength(0);
}
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(MidRows);
Console.WriteLine();