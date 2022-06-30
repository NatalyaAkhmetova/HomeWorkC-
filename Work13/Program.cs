// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число_");
int n = Convert.ToInt32(Console.ReadLine());
n = (int)Math.Abs(n);
if (n < 100) Console.WriteLine("Третьей цифры нет");
else
{
   string strn = n.ToString();
   Console.WriteLine(strn[2]);
} 


