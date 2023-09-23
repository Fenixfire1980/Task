


Console.WriteLine("Введите первое целое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
int min = number2;
if (number1 == number2)
{
    Console.WriteLine("Числа равны.");
}
else if (number1 > number2)
{
    Console.WriteLine($"Большее число:{max}");
    Console.WriteLine($"Меньшее число:{min}");
}
else if (number1 < number2)
{
   
    Console.WriteLine($"Большее число:{min}");
    Console.WriteLine($"Меньшее число:{max}");
}
