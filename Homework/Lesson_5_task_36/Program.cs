// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] array = new int[5];
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-100, 100);
}
int countElementIndexsNotEven = 0;
for(int i = 1; i < array.Length; i = i + 2) countElementIndexsNotEven = countElementIndexsNotEven + array[i];
void PrintArray(int[] x)
{
    Console.WriteLine();
    Console.Write($"[{x[0]}");
    for(int i = 1; i < x.Length; i++)
    {
        Console.Write($", {x[i]}");
    }
    Console.Write("]");
    //Console.WriteLine();
}
PrintArray(array);
Console.Write($" -> {countElementIndexsNotEven}");
Console.WriteLine();