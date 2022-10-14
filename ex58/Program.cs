// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//ввод числа с комментарием
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

// метод умножения матриц
int[,] MultiplicationsMatrix(int[,] matrixA,int[,] matrixB)
{
    int[,] multimatrixAB = new int[matrixA.GetLength(0),matrixA.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            multimatrixAB[i,j] = matrixA[i,j] * matrixB[i, j];
        }
    }
    return multimatrixAB;
}

//mean
Console.Clear();
int m = ReadDate("Введите количество строк массивов: ");
int n = ReadDate("Введите количество столбцов массивов: ");
int[,] matrixA = InitArray(m, n);
int[,] matrixB = InitArray(m, n);
Console.WriteLine("матрица A");
PrintArray(matrixA);
Console.WriteLine("матрица B");
PrintArray(matrixB);
int[,] matrixAB = MultiplicationsMatrix(matrixA,matrixB);
Console.WriteLine("матрица A*B");
PrintArray(matrixAB);
