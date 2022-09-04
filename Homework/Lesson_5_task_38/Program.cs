// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int i = 0;
double[] array = new double [100];
string t = "";
while(t != "end")
{
    t = Console.ReadLine();
    if(t != "end") array[i] = Convert.ToDouble(t);
    i++;
}
i = i - 1;
double Min(double[] x, int n)
{
    double m = x[0];
    for(int i = 1; i < n; i++) if(m > x[i]) m = x[i];
    return m;
}
double Max(double[] x, int n)
{
    double m = x[0];
    for(int i = 1; i < n; i++) if(m < x[i]) m = x[i];
    return m;
}
void PrintArray(double[] x, int n)
{
    Console.WriteLine();
    Console.Write($"[{x[0]}");
    for(int i = 1; i < n; i++)
    {
        Console.Write($", {x[i]}");
    }
    Console.Write("]");
    //Console.WriteLine();
}
PrintArray(array, i);
Console.Write($" -> {Max(array, i) - Min(array, i)}");
Console.WriteLine();