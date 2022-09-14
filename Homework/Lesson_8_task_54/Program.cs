// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int[,] array = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int temp;
void PrintArray(int[,] x)
{
    Console.WriteLine();
    for (int i = 0; i < x.GetLength(0); i++)
    {
        for (int j = 0; j < x.GetLength(1); j++) Console.Write($"{x[i, j]} ");
        Console.WriteLine();
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int k = 0; k < array.GetLength(1); k++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (array[i, j] > array[i, j + 1])
            {
                temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
            }
        }
    }
}
Console.WriteLine("Упорядоченный массив:");
PrintArray(array);