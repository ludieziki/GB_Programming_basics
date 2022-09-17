// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] array = new int[6, 5];
//размер массива можно менять в строке задания либо добавить ввод размера с консоли
int k = 1; int m = array.GetLength(0) - 1; int n = array.GetLength(1) - 1; int m0 = 0; int n0 = 0;
void PrintMatrix(int[,] x)
{
    for (int i = 0; i < x.GetLength(0); i++)
    {
        for (int j = 0; j < x.GetLength(1); j++)
        {
            if (x[i, j] < 10) Console.Write($"0{x[i, j]} ");
            else Console.Write($"{x[i, j]} ");
        }
        Console.WriteLine();
    }
}
void MoveOneStep(int l, int n)
{
    array[l, n] = k;
    k++;
}
while (k < array.GetLength(0) * array.GetLength(1) + 1)
{
    for (int j = n0; j < n + 1; j++) MoveOneStep(m0, j);
    for (int i = m0 + 1; i < m + 1; i++) MoveOneStep(i, n);
    for (int j = n - 1; j > n0 - 1; j--) MoveOneStep(m, j);
    for (int i = m - 1; i > n0; i--) MoveOneStep(i, n0);
    m--; m0++; n--; n0++;
}
PrintMatrix(array);