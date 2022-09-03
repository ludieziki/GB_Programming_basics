// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] array = new int[5];
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 999);
}
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
var IsEven = (int v) => v % 2 == 0;
int CountEvenArray(int[] x)
{
    int n = 0;
    for(int i = 0; i < x.Length; i++) if(IsEven(x[i]) == true) n++;
    return n;
}
PrintArray(array);
Console.WriteLine($"содержит {CountEvenArray(array)} четных элементов");