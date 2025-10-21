using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Программа для вычисления площади треугольника по трем сторонам");

        try
        {
            Console.WriteLine("Введите длину первой стороны:");
            double a = GetPositiveNumber();

            Console.WriteLine("Введите длину второй стороны:");
            double b = GetPositiveNumber();

            Console.WriteLine("Введите длину третьей стороны:");
            double c = GetPositiveNumber();

            double area = CalculateTriangleArea(a, b, c);
            Console.WriteLine($"Площадь треугольника: {area}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }

    }

    static double CalculateTriangleArea(double a, double b, double c)
    {
        try
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Треугольник с такими сторонами не существует");
            }

            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }
        catch (ArgumentException ex)
        {
            throw new ArgumentException($"Ошибка при вычислении площади: {ex.Message}");
        }
        catch (Exception ex)
        {
            throw new Exception($"Математическая ошибка: {ex.Message}");
        }
    }
}