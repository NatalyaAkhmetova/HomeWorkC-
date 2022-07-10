// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму
//элементов, стоящих на нечётных позициях.
int[] array = new int[12];
for (int i = 0; i < 12; i++)
{
  array[i] = new Random().Next(10, 100);
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
int sum = 0;
for (int i = 1; i < 12;)
{
    sum = sum + array[i];
    i = i+2;
}
Console.WriteLine(sum);