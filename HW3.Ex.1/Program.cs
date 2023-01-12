// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

double GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Convert.ToInt32(GetNumber("Пятизначное число = "));
int ClassOfNumber = 10000;

// void Answer(int number, int ClassOfNumber)
{
    while (number < 100000 && ClassOfNumber >= 1)
    {
        int lastN = number % 10;
        int firstN = number / ClassOfNumber;
        if (lastN == firstN)
        {
            number = number % ClassOfNumber / 10;
            ClassOfNumber = ClassOfNumber / 100;
        }
        else
        {
            System.Console.WriteLine("Число не является палиндромом");
            break;
        }
    }
    if (ClassOfNumber == 0)
    {
        Console.WriteLine("Число является палиндромом");
    }
    
}



// System.Console.WriteLine(Answer(number, ClassOfNumber));



