// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(n,m) = 29
int m = 4; int n = 3;
int A(int a, int b)
{
    if (a == 0) return b + 1;
    else
    {
        if (a != 0 & b == 0) return A(a - 1, 1);
        else return A(a - 1, A(a, b - 1));
    }
}
Console.WriteLine($"m = {n}, n = {m} -> A({m}, {n}) = {A(n, m)}");