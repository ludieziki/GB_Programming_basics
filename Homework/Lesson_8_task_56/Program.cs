// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int[,] array = new int[4, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
int SummLineElements(int[,] x, int i) // Метод принимает массив и находит сумму элементов требуемой строки
{
    int y = 0;
    for (int j = 0; j < x.GetLength(1); j++) y = y + x[i, j];
    return y;
}
int FindMinSummLineNumber(int[,] x)
{
    int y = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        if (SummLineElements(x, i) < SummLineElements(x, y)) y = i;
    }
    return y;
}
Console.WriteLine($"номер строки с наименьшей суммой элементов: {FindMinSummLineNumber(array) + 1} строка");