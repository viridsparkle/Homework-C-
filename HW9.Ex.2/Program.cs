//  Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// 1. Ввод M и N
(int m, int n) GetNumbersByUser()
{
    System.Console.Write("M = ");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("N = ");
    int n = Convert.ToInt32(Console.ReadLine());
    return (m, n);
}

// 2. Сумма натуральных элементов в промежутке от M до N
int SumFromMToN(int m, int n)
{
    if (m == n) return n;
    else return m + SumFromMToN(m + 1, n);
}

// 3. Распечатать результат
string GoodPrint(int result)
{
    return $"Сумма натуральных элементов в промежутке от M до N: {result}";
}

(int m, int n) numbers = GetNumbersByUser();
int sum = SumFromMToN(numbers.m, numbers.n);
System.Console.WriteLine(GoodPrint(sum));