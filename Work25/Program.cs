// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
/*Console.WriteLine("Введите число A:_");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:_");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("A^B = " + Math.Pow(A, B));*/


/*Console.WriteLine("Введите число A:_");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:_");
int B = Convert.ToInt32(Console.ReadLine());
int dgrA = A, i = 1;
while (i < B)
{
    dgrA = dgrA * A;
    i++;
}
Console.WriteLine(dgrA);*/


Console.WriteLine("Введите число A:_");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:_");
int B = Convert.ToInt32(Console.ReadLine());
int dgrA = A;
for (int i = 1; i < B; i++)
{
    dgrA = dgrA * A;
}
Console.WriteLine(dgrA);