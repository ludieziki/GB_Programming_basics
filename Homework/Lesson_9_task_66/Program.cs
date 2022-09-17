// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int m = 4; int n = 8;
int SummBetweenMandN(int a, int b)
{
    int y = 0;
    for (int i = a; i < b + 1; i++) y = y + i;
    return y;
}
Console.WriteLine($"M = {m}; N = {n} -> {SummBetweenMandN(m, n)}");