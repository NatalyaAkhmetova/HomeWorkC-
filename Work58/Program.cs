// Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.

int[,] array = new int[3, 3];
int[,] array2 = new int[3, 3];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(-10, 10);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Умножить");
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i, j] = new Random().Next(-10, 10);
        Console.Write(array2[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Результат");
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        Console.Write(array[i, j] * array2[i, j] + "\t");
    }
    Console.WriteLine();
}

