// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// 1. Ввод N
// 2. Определение суммы цифр числа
// 3. Печать результата

// 1. Ввод N
int GetNumberByUser(string text)
{
    System.Console.WriteLine(text + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

// 2. Определение суммы цифр числа
int GetSum(int N)
{
    int sum = 0;
    for (int n = 0; N >= 1; N = N / 10)
    {
        n = N % 10;
        sum = sum + n;
    }
    return sum;
}

// 3. Печать результата
string GoodPrint(string text, int result)
{
    return $"{text} {result}";
}

int N = GetNumberByUser("Введите число ");
int result = GetSum(N);
System.Console.WriteLine(GoodPrint("Сумма цифр в числе = ", result));
