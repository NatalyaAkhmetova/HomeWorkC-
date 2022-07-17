// Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.
double[, ] GreatMatr(int n, int m)
{
    double[, ] matrix = new double[n, m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
           matrix[i, j] = new Random().NextDouble();
           
       } 
    }
    return matrix;
}

void PrintMatr(double [, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
           Console.Write(Math.Round(matrix[i, j], 2) + "  ");
       }
       Console.WriteLine(); 
    }
}

PrintMatr(GreatMatr(3, 4));
