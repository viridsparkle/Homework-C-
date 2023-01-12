// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double GetDistance(double xa, double ya, double za, double xb, double yb, double zb)
{
    return Math.Sqrt(Math.Pow(xa - xb, 2) 
                    + Math.Pow(ya - yb, 2)
                    + Math.Pow(za - zb, 2));
}

double GetValue(string text)
{
    System.Console.Write(text);
    return Convert.ToDouble(System.Console.ReadLine());
}

double xa = GetValue("xa = ");
double ya = GetValue("ya = ");
double za = GetValue("za = ");
double xb = GetValue("xb = ");
double yb = GetValue("yb = ");
double zb = GetValue("zb = ");

double distance = GetDistance(xa, ya, za, xb, yb, zb);
System.Console.WriteLine(distance);
