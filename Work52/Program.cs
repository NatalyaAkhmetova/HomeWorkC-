// Задача 52. 
//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
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

void PrintMatr(int [, ] matrix)
{
    int[] sumCol = new int[3];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
           Console.Write(matrix[i, j] + " \t");
           sumCol[i] += matrix[j, i];
       }
       Console.WriteLine(); 
    }
    Console.WriteLine();
    foreach (double elem in sumCol)
    {
        Console.WriteLine("Среднее арифметическое столбца равно:" + elem/3);
    }
}
PrintMatr(GreatMatr(3, 3));

