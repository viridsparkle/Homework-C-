// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int a = 78;

string str = a.ToString();
int lenght = str.Length;
int findIndex = 2;

if (findIndex < lenght)
{
    Console.WriteLine(str[findIndex]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}