Console.Clear();

Console.WriteLine("Пожалуйста, введите координаты точек");
Console.Write("X: ");
int xC = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yC = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xC, yC);

string quarterStr = QuarterStr(xC, yC);

Console.WriteLine(quarter == 0 ? "Введены не корректные координаты" : quarter);

int Quarter(int x, int y)
{
if(x > 0 && y > 0) return 1;
if(x < 0 && y > 0) return 2;
if(x < 0 && y < 0) return 3;
if(x > 0 && y < 0) return 4;
return 0;
}

string QuarterStr(int x, int y)
{
if(x > 0 && y > 0) return "Первая четверть";
else if(x < 0 && y > 0) return "Вторая четверть";
else if(x < 0 && y < 0) return "Третья четверть";
else if(x > 0 && y < 0) return "Четвертая четверть";
return "Введите корректные координаты";
}

Console.WriteLine(quarterStr);
