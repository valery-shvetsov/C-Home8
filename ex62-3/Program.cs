// Напишите программу, которая заполнит спирально массив 4 на 4

//ввод числа с коментарием
int ReadDate(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
//задание массива
int[,] InitArray(int m)
{
    int[,] array = new int[m, m];
    double k = (double)m / 2;
    int sMax = m * m;
    int m1 = m - 1;
    //int n1=n-1;
    //Console.WriteLine();
    //Console.WriteLine(sMax.ToString());
    //Console.WriteLine(k.ToString());
    if (k % 2 != 0)
    {
        k = k + 0.5;
    }
    //Console.WriteLine(k.ToString());
    //Console.WriteLine();
    int ots = 0;
    int s = 1;
    //int x;
    //int y;
    //обход по кругам
    for (int j = 1; j <= k; j++)
    {
        //Console.WriteLine(ots.ToString());
        //Console.WriteLine();

        //верхняя горизонталь
        for (int i = ots; i <= m1 - ots - 1; i++)
        {
            //Console.WriteLine(s.ToString());
            array[ots, i] = s; s++;
            if (s > sMax) break;
        }
        //Console.WriteLine();
        //правая вертикаль
        for (int i = ots; i <= m1 - ots - 1; i++)
        {
            //Console.WriteLine(s.ToString());
            array[i, m1 - ots] = s; s++;

            if (s > sMax) break;
        }
        //Console.WriteLine();
        //нижняя горизонталь
        for (int i = m1 - ots; i >= ots + 1; i--)
        {
            //Console.WriteLine(s.ToString());
            array[m1 - ots, i] = s; s++;

            if (s > sMax) break;
            //Console.WriteLine();
        }
        //левая вертикаль
        for (int i = m1 - ots; i >= ots + 1; i--)
        {
            //Console.WriteLine(s.ToString());
            array[i, ots] = s; s++;

            if (s > sMax) break;
            // Console.WriteLine();
        }
        if (s < sMax)
        {
            ots++;
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
            if (array[i, j] < 10) Console.Write($"0{array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

//main
//Console.Clear();
int m = ReadDate("Введите четное количество строк и столбцов массива: ");
//int n = ReadDate("Введите количество столбцов массива: ");
int[,] realArray = InitArray(m);
PrintArray(realArray);
