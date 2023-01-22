// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// 1. Ввод m и n
// 2. Создание массива
// 3. Заполнение массива (ввод данных с консоли)
// 4. Распечатать матрицу
// 5. Метод поиска элемента в матрице

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

// 4. Распечатать матрицу
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j], 5}");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

// 5. Метод поиска элемента в матрице
void SearchNumberInMatrix(int[,] matrix)
{
    System.Console.Write($"Введите номер строки искомого элемента: ");
    int userI = Convert.ToInt32(Console.ReadLine());
    System.Console.Write($"Введите номер столбца искомого элемента: ");
    int userJ = Convert.ToInt32(Console.ReadLine());
   
    if (userI < matrix.GetLength(0)
        && userJ < matrix.GetLength(1))
    {
        int i = userI;
        int j = userJ; 
        System.Console.WriteLine($"Значение искомого элемента = {matrix[i, j]}");     
    }
    else System.Console.WriteLine("Такого элемента в массиве нет");
}

(int m, int n) size = GetSizeByUser();
int m = size.m;
int n = size.n;
int[,] matrix = CreateMatrix(m, n);
GetMatrixByUser(matrix);
PrintMatrix(matrix);
SearchNumberInMatrix(matrix);


