// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите элемент №" + (i + 1));
    array[i] = Convert.ToInt32(Console.ReadLine());
    
}
Console.WriteLine();
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


PrintArray(array);
//Console.WriteLine(array[i]);