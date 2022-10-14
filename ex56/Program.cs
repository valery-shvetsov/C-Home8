// адайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//ввод числа с коментарием
int ReadDate(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
//вывод числа с коментарием
void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
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
//печать одномерного массива
void PrintArray1(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


// метод нахождения суммы элементов в строках. создаем массив сумм
int[] ArraySum(int[,] array)
{
    int[] arraySum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arraySum[i] = arraySum[i] + array[i, j];
        }
    }
    return arraySum;
}
// метод нахождения индекса минимума в массиве
int IndexArrayMin(int[] array1)
{
    //int [] array = new int[array1.Length]; 
    int arrayMin = 100;
    int indexArrayMin = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (arrayMin > array1[i])
        {
            arrayMin = array1[i];
            indexArrayMin = i;
        }
    }
    return indexArrayMin + 1;
}

//mean
Console.Clear();
int m = ReadDate("Введите количество строк массива: ");
int n = ReadDate("Введите количество столбцов массива: ");
int[,] realArray = InitArray(m, n);
Console.WriteLine("Исходная матрица");
PrintArray(realArray);
Console.WriteLine("Суммы строк");
int[] sumArray = ArraySum(realArray);
PrintArray1(sumArray);
int indexMinSumString = IndexArrayMin(sumArray);
Console.WriteLine();
PrintData($"Номер строки с минимальной суммой элементов: ", indexMinSumString.ToString());

//Console.WriteLine("Отсортированная матрица");
//int[,] resaltArray = SortString(realArray);
//int[,] RealArray = ArithMeanArray(RealArray);

//PrintArray(resaltArray);