// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6




int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int ThirdDigit(int num)
{
    int result = -1;
    if (num >= 100)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        result = num % 10;
    }
    return result;
}

int number = GetUserInput("Введите число");

if (number < 0) number *= -1;
if (ThirdDigit(number) == -1)
{
    Console.WriteLine("трейтей цифры нет");
}
else
{
    Console.WriteLine($"{number} -> {ThirdDigit(number)}");
}
