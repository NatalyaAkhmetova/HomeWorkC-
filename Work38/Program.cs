// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и
//минимальным элементов массива.
int[] array = new int[10];
for (int i = 0; i < 10; i++)
{
  array[i] = new Random().Next(10, 100);
}
Console.WriteLine("[" + string.Join(", ", array) + "]");

int min_i = array[0];
int max_i = array[0];
for (int i = 1; i < 10; i++)
{
    if (array[i] > max_i) max_i = array[i];
    if (array[i] < min_i) min_i = array[i];
}

Console.WriteLine(max_i - min_i);