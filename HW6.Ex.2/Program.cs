// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1x + b1 = k2x + b2
// k1 * x - k2 * x = b2 - b1
// (k1 - k2) * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)

// int[] GetData(int size);
// {
//     System.Console.WriteLine("b1 = ");
//     int b1 = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("k1 = ");
//     int k1 = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("b2 = ");
//     int b2 = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("k2 = ");
//     int k2 = Convert.ToInt32(Console.ReadLine());
//     return new int[size] {b1, k1, b2, k2};
// }

// int[] data = GetData();

// 1. Ввод N
int GetNumberByUser(string text)
{
    System.Console.WriteLine("Введите число : ");
    return Convert.ToInt32(Console.ReadLine());
}

// 2. Создание массива
int[] CreateArray(int size)
{
    return new int[size];
}

// 3. Заполнение массива (ввод данных с консоли)
void GetArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        // if (i = 0) System.Console.WriteLine($"{("b1 = ")}");
        // if (i = 1) System.Console.WriteLine("k1 = ");
        // if (i = 2) System.Console.WriteLine("b2 = ");
        // if (i = 3) System.Console.WriteLine("k2 = ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}


