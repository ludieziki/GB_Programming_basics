﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Вводом числа пользователем пренебрегаю
int x = 5;
void CubeToN(int number)
{
    Console.Write(number);
    Console.Write(" -> ");
    for(int i = 1; i < number; i++)
    {
        Console.Write(Math.Pow(i, 3));
        Console.Write(", ");
    }
    Console.Write(Math.Pow(number, 3));
}
CubeToN(x);