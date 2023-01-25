// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// 1. Ввод m и n
// 2. Создание матрицы
// 3. Заполнение матрицы (ввод данных с консоли)
// 4. Распечатать матрицу
// 5. Метод нахождения суммы элементов в каждой строке матрицы
// 6. Метод нахождения строки c минимальным элементом матрицы
// 7. Распечатать результат

// 1. Ввод m и n
(int m, int n) GetSizeByUser()
{
    System.Console.Write("m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    return (m, n);
}

// 2. Создание матрицы
int[,] CreateMatrix(int m, int n)
{
    return new int[m, n];
}

// 3. Заполнение матрицы (ввод данных с консоли)
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

// 5. Метод нахождения суммы элементов в каждой строке матрицы
int[,] FindSumOfString(int[,] matrix)
{
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
    int[,] sumMatrix = new int [m, 1];
    for (int k = 0; k < sumMatrix.GetLength(1); k++)
    {
        for (int i = 0; i < m; i++)
        {
            int sum = 0;
            for (int j = 0; j < n; j++)
            {
                sum = sum + matrix[i, j];
            }
            sumMatrix[i, k] = sum;
        }
    }
    return sumMatrix;
}

// 6. Метод нахождения строки c минимальным элементом матрицы
int FindStringWithMin(int[,] matrix)
{
    int min = matrix[0, 0];
    int position = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (matrix[i, j] < min)  
            {
                min = matrix[i, j];
                position = i;
            }
        }
    }
    return position;
}

// 7. Распечатать результат
string GoodPrint(int result)
{
    return $"Номер строки с наименьшей суммой элементов: {result}";
}


(int m, int n) size = GetSizeByUser();
int[,] matrix = CreateMatrix(size.m, size.n);
GetMatrixByUser(matrix);
PrintMatrix(matrix);
int[,] sumMatrix = FindSumOfString(matrix);
int numberOfString = FindStringWithMin(sumMatrix);
System.Console.WriteLine(GoodPrint(numberOfString));
