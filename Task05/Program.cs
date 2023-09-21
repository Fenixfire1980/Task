Console.Write("Введите натуральное число больше 0: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int count = -number;
    while (count <= number)
    {
        Console.Write($"{count} ");
        count += 1;
    }
}
else
{
    Console.WriteLine("Ошибка ввода");
}