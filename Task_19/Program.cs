Console.Clear();

Console.WriteLine("Пожалуйста, введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

void SecondDigit(int num)
{
    int firstDigit = num / 10000;
    int secondDigit = (num / 1000) % 10;
    int fourthDigit = (num / 10) % 10;
    int fifthDigit = num % 10;

    if (firstDigit == fifthDigit && secondDigit == fourthDigit) Console.WriteLine("да");
   else Console.WriteLine("нет");
}
if (number > 9999 && number < 100000) SecondDigit(number);
else Console.WriteLine("Введено не корректное число");


