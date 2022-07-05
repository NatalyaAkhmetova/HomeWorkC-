// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число_");
int sum = 0, n = Convert.ToInt32(Console.ReadLine());
while (n > 0)
{
    sum = sum + n%10;
    n = n / 10; 
}
Console.WriteLine(sum);
