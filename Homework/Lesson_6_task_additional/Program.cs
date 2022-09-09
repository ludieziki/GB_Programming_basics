// Дополнительная задача на рекурсию
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. (использовать рекурсию)
// 4 -> 24
// 5 -> 120
int n = 5;
int Factorial(int x)
{
    if (x == 1) return 1;
    else return x * Factorial(x - 1);
}
Console.WriteLine($"{n} -> {Factorial(n)}");