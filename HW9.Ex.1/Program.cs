// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// 1. Ввод n
int GetNByUser()
{
    System.Console.Write("Введите n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

// 2. Вывод натуральных чисел от 1 до N
string Numbers(int n)
{
    if (n == 1) return $"{1}";
    else return $"{n}, " + Numbers(n - 1);
}

// 3. Распечатать результат
string GoodPrint(string result)
{
    return $"Все натуральные числа в промежутке от N до 1: {result}";
}

int n = GetNByUser();
System.Console.WriteLine(GoodPrint(Numbers(n)));