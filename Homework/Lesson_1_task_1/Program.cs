// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
Console.WriteLine("Введите проверяемое число (целое)");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число на равенство квадрату которого проверяем предыдущее");
int B = Convert.ToInt32(Console.ReadLine());
if (A == B*B)
{
    Console.WriteLine("Да, число ");
    Console.WriteLine(A);
    Console.WriteLine("является квадратом ");
    Console.WriteLine(B);    
}
else
{
    Console.WriteLine("Нет, число ");
    Console.WriteLine(A);
    Console.WriteLine("не является квадратом ");
    Console.WriteLine(B);    
}