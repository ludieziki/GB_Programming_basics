// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
string text = Console.ReadLine();
string[] subs = text.Split(' ', '\t', ',');
int[] array = new int[subs.Length];
for (int i = 0; i < subs.Length; i++)
{
    array[i] = Convert.ToInt32(subs[i]);
}
int CountPositive(int[] x)
{
    int y = 0;
    for(int i = 0; i < x.Length; i++) if(x[i]>0) y++;
    return y;
}
void PrintArray(int[] x)
{
    Console.WriteLine();
    Console.Write($"[{x[0]}");
    for(int i = 1; i < x.Length; i++)
    {
        Console.Write($", {x[i]}");
    }
    Console.Write("]");
    //Console.WriteLine();
}
PrintArray(array);
Console.Write($" -> {CountPositive(array)} положительных чисел");
Console.WriteLine();