// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1x + b1 = k2x + b2
// k1 * x - k2 * x = b2 - b1
// (k1 - k2) * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)

// 1. Ввод данных
// 2. Метод получения координат точки пересечения прямых
// 3. Распечатать результат

// 1. Ввод данных
(double a, double b, double c, double d) GetData()
{
    System.Console.WriteLine("b1 = ");
    double a = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("k1 = ");
    double b = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("b2 = ");
    double c = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("k2 = ");
    double d = Convert.ToDouble(Console.ReadLine());
    return (a, b, c, d);
}

// 2. Метод получения координат точки пересечения прямых
(double x, double y) GetXY(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}

// 3. Распечатать результат
string GoodPrint(double x, double y)
{
    return $"Координаты точки пересечения двух прямых: ( {x}; {y} )";
}


(double a, double b, double c, double d) data = GetData();
double b1 = data.a;
double k1 = data.b;
double b2 = data.c;
double k2 = data.d;


(double x, double y) point = GetXY(b1, k1, b2, k2);
System.Console.WriteLine(GoodPrint(point.x, point.y));

