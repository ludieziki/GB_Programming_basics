// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Введите первое число (целое)");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
if (A > B)
{
    Console.WriteLine("Число ");
    Console.WriteLine(A);
    Console.WriteLine("больше, чем ");
    Console.WriteLine(B);    
}
else
{
    if (A < B)
    {
        Console.WriteLine("Число ");
        Console.WriteLine(B);
        Console.WriteLine("больше, чем ");
        Console.WriteLine(A); 
    }
    else
    {
        Console.WriteLine("Число ");
        Console.WriteLine(B);
        Console.WriteLine("равно");
        Console.WriteLine(A);
    }
}