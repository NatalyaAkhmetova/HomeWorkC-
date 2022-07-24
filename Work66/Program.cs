// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от N до M.

int Sum(int n, int m)
{   
    if (n == m) return n;
    else return m + Sum(n, (m - 1)); 

}

int n = 3;
int m = 10;

Console.Write(Sum(n, m));

