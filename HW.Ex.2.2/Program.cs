// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 44 5 78 -> 78

int a = 44;
int b = 5;
int c = 78;

int max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}

Console.Write("max = ");
Console.WriteLine(max);
