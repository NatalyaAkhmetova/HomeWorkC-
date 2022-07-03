// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double xa, ya, xb, yb, za, zb, len;
xa = Convert.ToDouble(Console.ReadLine());
ya = Convert.ToDouble(Console.ReadLine());
za = Convert.ToDouble(Console.ReadLine());
xb = Convert.ToDouble(Console.ReadLine());
yb = Convert.ToDouble(Console.ReadLine());
zb = Convert.ToDouble(Console.ReadLine());
len = Math.Sqrt((xa - xb)*(xa - xb) + (ya - yb)*(ya - yb) + (za - zb)*(za - zb));
Console.WriteLine(len);

