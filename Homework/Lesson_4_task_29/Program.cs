// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] Array = {1, 2, 5, 7, 19};
void PrintArray(int[] x)
{
    Console.WriteLine();
    Console.Write($"[{x[0]}");
    for(int i = 1; i < x.Length; i++)
    {
        Console.Write($", {x[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}
PrintArray(Array);