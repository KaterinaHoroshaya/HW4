/* Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом.

5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33] */

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers, 1, 150);
WriteArray(numbers);

Console.WriteLine("Введите размер второго массива: ");
int size2 = Convert.ToInt32(Console.ReadLine());
int[] numbers2 = new int[size2];

FillArrayRandomNumbers(numbers2, 200, 250);
WriteArray(numbers2);


void FillArrayRandomNumbers(int[] array, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}