// Написать программу, которая найдет точку пересечения двух прямых,
//заданных уравнениями y=k1*x+b1, y=k2*x+b2;
//значения k1,k2,b1,b2 задаются пользователем.
double k1, k2, b1, b2;
Console.WriteLine("Введите k1 ");
k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2 ");
k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1 ");
b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2 ");
b2 = Convert.ToInt32(Console.ReadLine());
if (k1 == k2) Console.WriteLine("Прямые параллельны");
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    Console.WriteLine($"({x};{y})");
    //Console.WriteLine("x=" + x);
    //Console.WriteLine("y=" + y);
}

