// Задача 28*: Напишите программу, в которой задается массив чисел(ввод может быть с клавиатуры, 
//либо можете сами задавать массив чисел) и выдаёт произведение чисел от 1 до N, каждого элемента этого массива.
// {2, 3, 4} -> 2, 6, 24
// {5, 3, 6, 2, 5, 1} -> 6, 720, 2, 120, 1
int[] Array = {5, 3, 6, 2, 5, 1};
int[] ArrayNew = new int[Array.Length];
void PrintArray(int[] x)
{
    //Console.WriteLine();
    Console.Write(x[0]);
    for(int i = 1; i < x.Length; i++)
    {
        Console.Write($", {x[i]}");
    }
    //Console.Write("] -> ");    
}
void MultArray(int[] x)
{
    for(int i = 0; i < x.Length; i++)
    {
        ArrayNew[i] = 1;
        for(int j = 1; j < x[i]+1; j++)
        {
            ArrayNew[i] = ArrayNew[i] * j;
        }
    }
}
MultArray(Array);
Console.Clear();
Console.Write("{");
PrintArray(Array);
Console.Write("} -> ");
PrintArray(ArrayNew);
Console.WriteLine();