Console.Clear();

Console.WriteLine("Пожалуйста, введите число");
int num = Convert.ToInt32(Console.ReadLine());

void SquareTable(int number)
{
    int counter = 1;
    while (counter <= number)
    {
        System.Console.WriteLine($"{counter} {counter * counter}");
        counter++;
    }
}

if (num > 0) SquareTable(num);
else Console.WriteLine("Введено не корректное число");