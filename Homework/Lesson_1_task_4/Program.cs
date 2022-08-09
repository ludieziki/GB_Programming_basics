// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
int[] Numbers = new int[3];
int Count = 0;
while (Count < 3)
{
    Console.WriteLine("Введите число (целое) номер ");
    Console.WriteLine(Count+1);
    Numbers[Count] = Convert.ToInt32(Console.ReadLine());
    Count++;    
}
Count = 1;
int Max = Numbers[0];
while (Count < 3)
{
if (Max < Numbers[Count])
{
    Max = Numbers[Count];
    Count++;    
}
else
{
    Count++;
}
}
Console.WriteLine("Максимальное число равно ");
Console.WriteLine(Max);