Console.Clear();

Console.WriteLine("Пожалуйста, введите координаты точек");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());


double Distance (int a, int b, int c, int d)
{
double res = Math.Sqrt(Math.Pow((c-a), 2) + Math.Pow((d-b), 2));
double res1 = Math.Round(res, 2, MidpointRounding.ToZero);
return res1;
}

double result = Distance(x1, y1, x2, y2);
Console.WriteLine($"Расстояние между точками равно {result}");