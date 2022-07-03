// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число:_");
int n = Convert.ToInt32(Console.ReadLine());
string strn = n.ToString();
if (strn[0] == strn[4] && strn[1] == strn[3]){
    Console.WriteLine("Число является палиндромом.");
}
else Console.WriteLine("Число не является палиндромом.");
