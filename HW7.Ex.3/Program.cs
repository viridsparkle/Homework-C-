// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 
// 4,6; 5,6; 3,6; 3.

// 1. Ввод m и n
// 2. Создание массива
// 3. Заполнение массива (ввод данных с консоли)
// 4. Метод расчета среднего арифметического в каждом столбце
// 5. Распечатать результат


// 1. Ввод m и n
(int m, int n) GetSizeByUser()
{
    System.Console.Write("m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    return (m, n);
}

// 2. Создание массива
int[,] CreateMatrix(int m, int n)
{
    return new int[m, n];
}

// 3. Заполнение массива (ввод данных с консоли)
void GetMatrixByUser(int[,] matrix)
{
    System.Console.WriteLine("Введите элементы матрицы построчно: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"matrix[{i}, {j}] = ");
            matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

// 4. Метод расчета среднего арифметического в каждом столбце
double[] FindAverageForN(int[,] matrix, double m)
{
    int n = matrix.GetLength(1);
    double[] array = new double[n];
    for (int j = 0; j < n; j++)
    {
        double sum = 0;
        double average = 0;
        for (int i = 0; i < m; i++)
        {
            sum = sum + matrix[i, j];
        }
        average = Math.Round(sum / m, 1);
        array[j] = average;
    }
    return array;
}

// 5. Распечатать результат
string PrintResult(double[] array)
{
    return $"Среднее арифметическое каждого столбца: {String.Join(", ", array)}";
}

(int m, int n) size = GetSizeByUser();
int m = size.m;
int n = size.n;
int[,] matrix = CreateMatrix(m, n);
GetMatrixByUser(matrix);
double[] array = FindAverageForN(matrix, 3.0);
System.Console.WriteLine((PrintResult(array)));
