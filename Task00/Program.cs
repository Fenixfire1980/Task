// 1. Программа на вход принимает число
// 2. Выдает его в квадрате
// 3. Вывод результата

Console.WriteLine("Веедите целое число");
int number = Convert.ToInt32(Console.ReadLine());

int square = number * number;
//Console.WriteLine(number + " -> " + square);
Console.WriteLine($"{number} -> {square}");

