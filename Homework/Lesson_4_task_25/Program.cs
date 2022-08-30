// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Использование Math.Pow и аналогов = незачёт
// Вводом данных пользователем пренебрегаю
int A = 3, B = 5;
int ManualPow(int x, int y)
{
    int z = 1;
    for(int i = 1; i < y+1; i++)
    {
        z = z * x;
        // Console.WriteLine(x);
    }
    return z;
}
int C = ManualPow(A, B);
Console.WriteLine($"{A}^{B}={C}");