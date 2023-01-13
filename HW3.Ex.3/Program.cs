// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

double GetN ()
{
    return Convert.ToDouble(Console.ReadLine());
}

void Exponentiation(double N)
{
   for (int n = 1; n <= N; n++)
   {
    Console.WriteLine(Math.Pow(n,3));
   }
}
double N = Convert.ToDouble(GetN());
Exponentiation(N);
