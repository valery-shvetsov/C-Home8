// Сформируйте трёхмерный массив размером 2 x 2 x 2 из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.

//задание случайного массива
int[,,] InitArray(int m, int n, int p)
{
    int[,,] array = new int[m, n, p];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < p; k++)
            {
                array[i, j, k] = rnd.Next(10, 99);
            }
        }
    }
    return array;
}
//печать массива
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
    }
}
// main
Console.Clear();
int m = 2;
int n = 2;
int p = 2;
int[,,] array3D = InitArray(m, n, p);
PrintArray(array3D);