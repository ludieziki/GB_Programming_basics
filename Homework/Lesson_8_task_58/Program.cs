// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] matrixA = new int[2, 2] { { 2, 4 }, { 3, 2 } };
int[,] matrixB = new int[2, 2] { { 3, 4 }, { 3, 3 } };
void PrintMatrix(int[,] x)
{
    for (int i = 0; i < x.GetLength(0); i++)
    {
        for (int j = 0; j < x.GetLength(1); j++) Console.Write($"{x[i, j]} ");
        Console.WriteLine();
    }
}
if (matrixA.GetLength(1) != matrixB.GetLength(0))
{
    Console.WriteLine("Матрицы не согласованы. Операция умножения двух матриц не выполнима.");
}
else
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            int y = 0;
            for (int r = 0; r < matrixA.GetLength(1); r++)
            {
                y = y + matrixA[i, r] * matrixB[r, j];
            }
            matrixC[i, j] = y;
        }
    }
    Console.WriteLine("Результирующая матрица будет:");
    PrintMatrix(matrixC);
}