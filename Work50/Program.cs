// Задача 50. 
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] GreatMatr(int n, int m)
{
    int[,] matrix = new int[n, m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 100);
        }
    }
    return matrix;
}

void PrintMatr(int[,] matrix)
{
    Console.WriteLine("Введите номер строки  ");
    int i1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца  ");
    int j1 = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    if (i1 < 4 && j1 < 3) 
        Console.WriteLine("Значение элемента равно: " + matrix[i1, j1]);
    else Console.WriteLine("Такого элемента нет.");

}

PrintMatr(GreatMatr(4, 3));

