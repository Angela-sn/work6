// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите число В1: ");
double B1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите число K1: ");
double K1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите число В2: ");
double B2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите число K2: ");
double K2 = Convert.ToDouble(Console.ReadLine());

double x = X(B1, K1, B2, K2);
double y = Y(B1, K1);
x = Math.Round(x,2);
y = Math.Round(y,2);
Console.WriteLine($"точка пересечения 2-х прямых -> {x}, {y}");

double X(double B1, double K1, double B2, double K2)
{
    double x = -(B1 - B2) / (K1 - K2);
    return x;
}

double Y(double B1, double K1)
{
    double x = X(B1, K1, B2, K2);
    double y = K1 * x + B1;
    return x;
}
