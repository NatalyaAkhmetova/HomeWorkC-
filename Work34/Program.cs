// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
int[] array = new int[10];
for (int i = 0; i < 10; i++)
{
  array[i] = new Random().Next(100, 1000);
}
Console.WriteLine("[" + string.Join(", ", array) + "]");

int n = 0;
for (int i = 0; i < 10; i++)
{
  if (array[i]% 2 ==0) n = n + 1;
}
Console.WriteLine(n);