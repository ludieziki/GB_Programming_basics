// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
//
// Задаем массив произвольной величины и заполняем случайными числами
int m = 3; int n = 4;
double[,] array = new double[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().NextDouble();
}
Console.WriteLine("Введите позицию элемента в массиве (строка столбец");
string text = Console.ReadLine();
string[] subs = text.Split(' ', '\t', ',');
int[] position = new int[subs.Length];
for (int i = 0; i < subs.Length; i++)
{
    position[i] = Convert.ToInt32(subs[i]);
}
if (position[0] > array.GetLength(0)-1 || position[1] > array.GetLength(1)-1) Console.WriteLine("Такого числа в массиве нет");
else Console.WriteLine($"Строка {position[0]}, столбец {position[1]} -> {array[position[0], position[1]]}");