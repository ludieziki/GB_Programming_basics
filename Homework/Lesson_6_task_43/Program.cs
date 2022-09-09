// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine($"Введите последовательно значения k1, b1, и k2, b2");
Console.WriteLine($"для нахождения точки пересечения прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
string text = Console.ReadLine();
string[] subs = text.Split(' ', '\t');
double[,] array = new double[subs.Length/2, subs.Length/2];
int k = 0;
double x = 0; double y = 0;
for (int i = 0; i < subs.Length/2; i++)
{
    for(int j = 0; j < subs.Length/2; j++)
    {
     array[j, i] = Convert.ToInt32(subs[k]);
     k++;     
    }    
}
x = (array[1,1] - array[1,0]) / (array[0,0] - array[0,1]);
y = array[0, 0] * x + array[1, 0];
Console.WriteLine($"Прямые пересекаются в точке ({x};{y})");