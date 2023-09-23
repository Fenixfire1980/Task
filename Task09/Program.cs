

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка [10, 99] -> {number}");
int FirstDigit = number / 10;
int SecondDigit = number % 10;
// if (FirstDigit > SecondDigit) Console.WriteLine($"Наибольшая цифра числа -> {FirstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа -> {SecondDigit}");
// Тернарный оператор (тройной)
int maxDigit = FirstDigit > SecondDigit ? FirstDigit : SecondDigit;
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");
