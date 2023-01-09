// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int n = 456;
int n2 = 782;
int n3 = 918;

string str = n.ToString();
Console.WriteLine(str[1]);

string str2 = n2.ToString();
Console.WriteLine(str2[1]);

string str3 = n3.ToString();
Console.WriteLine(str3[1]);