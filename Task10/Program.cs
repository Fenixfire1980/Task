// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SecondDigit(int num)
{
    return (num / 10) % 10;
}

int number = GetUserInput("Введите певрое число");

if (number < 0) number *= -1;
if (number >= 100 && number <= 999)
{
    int Second = SecondDigit(number);
    Console.WriteLine($"Второе число {Second}");
}
else
{
    Console.WriteLine("Не коректный ввод");
}