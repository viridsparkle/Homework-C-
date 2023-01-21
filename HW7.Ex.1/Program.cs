//  Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// 1. Ввод m и n
// 2. Создание массива
// 3. Заполнение массива (случайные числа)
// 4. Распечатать результат

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
double[,] CreateMatrix(int m, int n)
{
    return new double[m, n];
}

// 3. Заполнение массива (случайные числа)
void GetMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] =  Convert.ToDouble(new Random().Next(-100,100) / 10.0);
        }
    }
}

// 4. Распечатать результат
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j], 6}");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

(int m, int n) size = GetSizeByUser();
int m = size.m;
int n = size.n;
double[,] matrix = CreateMatrix(m, n);
GetMatrix(matrix);
PrintMatrix(matrix);