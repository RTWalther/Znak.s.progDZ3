// Задача 21

// Напишите программу, которая 
// 1. принимает на вход координаты двух точек и 
// 2. находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A:");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double distance = Distance(x1 ,x2  ,y1 ,y2  ,z1 ,z2 );
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));

double Distance(int a1, int a2, int b1, int b2, int z1, int z2)
{
    double dist = Math.Sqrt((a1-a2)* (a1 -a2)+(b1-b2)* (b1 -b2)+(z1-z2)* (z1 -z2));
    return dist;
}
