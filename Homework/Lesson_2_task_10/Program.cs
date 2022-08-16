// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число");
string Inp = Console.ReadLine();
int Length = Inp.Length;
while(Length < 3 || Length > 3)
{
    Console.WriteLine("Вы ввели не трехначное число, введите трехзначное число");
    Inp = Console.ReadLine();
    Length = Inp.Length;
}
int X = Convert.ToInt32(Inp);
int H = X % 100;
int D = (H - H % 10) / 10;
Console.WriteLine($"Вторая цифра числа  {X}, это цифра {D}");