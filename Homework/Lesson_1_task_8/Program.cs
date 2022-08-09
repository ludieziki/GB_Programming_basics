// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
double Number;
int Even;
int Count = 2;
Console.WriteLine("Введите число для печати всех четных чисел от 1 до этого числа");
Number = Convert.ToDouble(Console.ReadLine());
if (Number > 2)
{
    if (Convert.ToInt32(Number) %2 == 0)
        {
            Even = Convert.ToInt32(Number) - 2;    
        }
    else
        {
            Even = Convert.ToInt32(Number) - 1;
        }
    while (Count < Even + 2)
        {
            Console.WriteLine(Count);
            Count = Count + 2;
        }
    Console.WriteLine("Это ряд четных чисел от 1 до ");
    Console.WriteLine(Number);
}
else
{
    Console.WriteLine("Для этого числе не существует ряда четных чисел от 1 до числа");
}