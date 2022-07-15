// Пользователь вводит с клавиатуры М чисел. 
//Посчитать, сколько чисел больше 0 введено
Console.WriteLine("Ведите колличество чисел ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите элемент №" + (i + 1));
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0) count++;
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine(count);