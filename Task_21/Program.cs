Console.Clear();

Console.WriteLine("Пожалуйста, введите координаты точек");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
{
    double res = Math.Sqrt(Math.Pow((arg4 - arg1), 2) + Math.Pow((arg5 - arg2), 2) + Math.Pow((arg6 - arg3), 2));
    double res1 = Math.Round(res, 2, MidpointRounding.ToZero);
    return res1;
}

double result = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(result);