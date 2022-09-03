// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
// А решать с вводом числа пользователем с консоли было бы проще!
int A = 9012;
int CountDigits(int x)
{
    string Amod = x.ToString();
    int Y = 0;
    for(int i= 0; i < Amod.Length; i++)
    {
        char B = Amod[i];
        Y = Y + int.Parse(B.ToString());    
    }
    return Y;
}
Console.WriteLine($"Сумма цифр в числе {A} равна {CountDigits(A)}");