// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// 1. Ввод m и n
(int m, int n) GetNumbersByUser()
{
    System.Console.WriteLine("Введите два неотрицательных числа:");
    System.Console.Write("m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    return (m, n);
}

// 2. Вычисление функции Аккермана
int A(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return A(m - 1, 1);
    else return A(m - 1, A(m, n - 1));
}

// 3. Распечатать результат
string GoodPrint(int result)
{
    return $"A(m, n) = {result}";
}

(int m, int n) numbers = GetNumbersByUser();
System.Console.WriteLine(GoodPrint(A(numbers.m, numbers.n)));
