// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// Использовал для проверки: int[] array = {10, 11, 12, 13, 14};
int[] array = new int[123];
Random rand = new Random();
for(int i = 0; i < array.Length; i++) array[i] = rand.Next();
int min = 10;
int max = 99;
int CountInInterval(int[] x, int a, int b)
{
    int y = 0;
    for(int i = 0; i < x.Length; i++)
    {
        if(x[i] > a & x[i] < b) y++;
        if(x[i] == a || x[i] == b) y++;
    }
    return y;
}
Console.WriteLine($"В заданном {array[11]} массиве {CountInInterval(array, min, max)} элементов в диапазоне [{min}, {max}]");