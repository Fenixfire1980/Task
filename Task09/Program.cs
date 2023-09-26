int number =new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка [10, 99] -> {number}");

// int firstDijit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// int maxDigit = FirstDigit > secondDigit ? firstDigit : secondDigit; // Тернарный оператор
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");
int MaxDigit (int num)
{
    int FirstDigit = num / 10;
    int SecondDigit = num % 10;
    return FirstDigit > SecondDigit ? FirstDigit : SecondDigit;
}