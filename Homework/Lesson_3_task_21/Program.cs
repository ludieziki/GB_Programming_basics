// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Вводом координат точек пользователем пренебрегаю
int[] PointA = {3, 6, 8};
int[] PointB = {2, 1, -7};
double D(int[] A, int[] B)
{
    double d = Math.Sqrt(Math.Pow(A[0]-B[0], 2) + Math.Pow(A[1]-B[1], 2) + Math.Pow(A[2]-B[2], 2));
    return d;
}
double y = D(PointA, PointB);
Console.WriteLine($"Расстояние между А ({PointA[0]},{PointA[1]},{PointA[2]}) и B ({PointB[0]},{PointB[1]},{PointB[2]}) = {y}");