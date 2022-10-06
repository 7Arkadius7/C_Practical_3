Console.Clear();

Console.WriteLine("Пожалуйста, введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());
string quarter = Quarter(number);
Console.WriteLine($"Ответ: {quarter}");

string Quarter(int num)
{
if (num == 1) return "x > 0, y > 0";
if (num == 2) return "x < 0, y > 0";
if (num == 3) return "x < 0, y < 0";
if (num == 4) return "x > 0, y < 0";
return "Введите корректную четверть";
}
