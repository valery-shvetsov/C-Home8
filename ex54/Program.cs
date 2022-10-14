// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

//ввод числа с коментарием
int ReadDate(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
//задание случайного массива
int[,] InitArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(0, 10);

        }
    }
    return array;
}
//печать массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
// метод сортировки элементов строки по убыванию
int[,] SortString(int[,] array)
{
    int[,] sortMatrix = new int[array.GetLength(0), array.GetLength(1)];
    int k;
    for (k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1 - i; j++)
            {
                if (array[k, j] < array[k, j + 1])
                {
                    int temp;
                    temp = array[k, j];
                    array[k, j] = array[k, j + 1];
                    array[k, j + 1] = temp;
                }
            }
        }
    }
    return array;
}

//mean
//Console.Clear();
int m = ReadDate("Введите количество строк массива: ");
int n = ReadDate("Введите количество столбцов массива: ");
int[,] realArray = InitArray(m, n);
Console.WriteLine("Исходная матрица");
PrintArray(realArray);
Console.WriteLine("Отсортированная матрица");
int[,] resaltArray = SortString(realArray);
PrintArray(resaltArray);
