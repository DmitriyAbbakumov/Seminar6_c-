// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите b2");
double b2 = Convert.ToInt32(Console.ReadLine());
double x = 0;
double y = 0;

void result(double ex, double ey, double ek1, double ek2, double eb1, double eb2)
{
    if (ek1 == ek2 && eb1 != eb2)
    {
        Console.WriteLine("прямые параллельны, нет точек пересечения");
    }
    else if (ek1 == ek2 && eb1 == eb2) Console.WriteLine("прямые совпадают");
    else
    {
        ex = (eb2 - eb1) / (ek1 - ek2);
        ey = (ek1 * eb2 - ek2 * eb1) / (ek1 - ek2);
        Console.WriteLine($"({ex}; {ey})");
    }
}
result(x, y, k1, k2, b1, b2);