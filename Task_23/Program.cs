Console.Clear();

Console.WriteLine("Пожалуйста, введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

void SquareTable(int number)
{
    int counter = 1;
    while (counter <= number)
    {
        System.Console.WriteLine($"| {counter,3} | {counter * counter * counter,3} |");
        counter++;
    }
}

if (num > 0) SquareTable(num);
else Console.WriteLine("Введено не корректное число");