try
{
    Console.WriteLine("Введите длыны сторон треугольника a, b, c: ");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    double minSide = Math.Min(a,Math.Min(b,c));
    double sqrArea = minSide + minSide;
    double semiPerimeter = (a + b + c) / 2;
    double triangleArea = Math.Sqrt(semiPerimeter *(semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
    Console.WriteLine($"Площадь квадрата: {sqrArea}");
    Console.WriteLine($"Площадь треугольника: {triangleArea}");
    if (sqrArea > triangleArea)
    {
        Console.WriteLine("Площадь квадрата больше площади треугольника.");
    }
    else if (sqrArea < triangleArea)
    {
        Console.WriteLine("Площадь треугольника больше площади квадрата.");
    }
    else
    {
        Console.WriteLine("Площади квадрата и треугольника равны.");
    }
}
catch
{
    Console.WriteLine("Введите правильно!");
}