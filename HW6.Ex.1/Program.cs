// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// 1. Ввод M
// 2. Ввод чисел и подсчет их количества больше 0
// 3. Распечатать результат

// 1. Ввод M
int GetNumberByUser(string text)
{
    System.Console.WriteLine("Введите число : ");
    return Convert.ToInt32(Console.ReadLine());
}

// 2. Ввод чисел и подсчет их количества больше 0
int GetCountOfNumbersAbove0(int n)
{
    int number = 0;
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        number = Convert.ToInt32(Console.ReadLine());
        // System.Console.Write(PrintNumbers(number));
        if (number > 0) count++;
    }
    return count;
}

// 3. Распечатать результат
string PrintResult(int result)
{
    return $"{("Количество чисел больше 0 = ")} {result}";
}

int m = GetNumberByUser("");
int count = GetCountOfNumbersAbove0(m);
System.Console.WriteLine(PrintResult(count));
