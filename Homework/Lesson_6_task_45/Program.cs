// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] array = {5, 7, 8, 9, 6, 7};
int[] reserveArray = new int[array.Length];
void copyArray(int[] x)
{
    for(int i = 0; i < x.Length; i++) reserveArray[i] = x[i];
}
copyArray(array);