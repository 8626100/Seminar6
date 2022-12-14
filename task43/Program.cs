//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine($"Введите угловой коэффициент k1 превой прямой ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите cвободный член b1 уравнения первой прямой ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите угловой коэффициент k2 превой прямой ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите cвободный член b2 уравнения первой прямой ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1>k2 || k1<k2)
{
    double x = (b2-b1)/(k1-k2);
    double y = x*k1+b1;
    Console.WriteLine($"Прямые пересекаются в точке ({x};{y})");
}
else
{
    Console.WriteLine($"Прямые параллельны или совпадают, точки пересечения нет");
}
