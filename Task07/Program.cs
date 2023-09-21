



Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;
if (number >= 100 && number <= 999)
{
int LastDigit = number % 10;
Console.WriteLine($"Последняя цифрв вашего числа {LastDigit}");
}
else 
{
    Console.WriteLine("Не коректный ввод");
}