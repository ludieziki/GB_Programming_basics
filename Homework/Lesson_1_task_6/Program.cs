// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
double Number;
Console.WriteLine("Введите число для проверки на четность");
Number = Convert.ToDouble(Console.ReadLine());
if (Number %2 == 0)
{
    Console.WriteLine("Это четное число");
}
else
{
    Console.WriteLine("Это нечетное число");
}