// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число");
string Inp = Console.ReadLine();
int Length = Inp.Length;
if(Length < 3)
{
    Console.WriteLine("третей цифры нет");
}
else
{
    int X = Convert.ToInt32(Inp);
    int S = Convert.ToInt32(Math.Pow(10, Length-3));
    int H = X / S;
    int D = H % 10;
    Console.WriteLine($"Третья {S} цифра числа  {H}, это цифра {D}");
}