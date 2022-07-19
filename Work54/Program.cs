// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[, ] GreatMatr(int n, int m)
{
    int[, ] matrix = new int[n, m];
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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
           int x ;
           for (int k = j + 1; k < matrix.GetLength(1); k++)
           {
             if (matrix[i, j] > matrix[i, k])
             {
                x = matrix[i, j];
                matrix[i, j] = matrix[i, k];
                matrix[i, k] = x;
             }
            
           }
           Console.Write(matrix[i, j] + " ");
       }
       Console.WriteLine(); 
    }
}
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
PrintMatr(GreatMatr(n, m));
