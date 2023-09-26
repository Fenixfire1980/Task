

string RangeCoordenates(int number)
{
    if (number == 1) return "x > 0 && y > 0";
    if (number == 2) return "x > 0 && y > 0";
    if (number == 3) return "x > 0 && y > 0";
    if (number == 4) return "x > 0 && y > 0";
    return null;
}

Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());


string range = RangeCoordenates(num);

string result = range != null
        ? $"Диапазон координат для указаной четверти {range}"
        : "Введен некоректный номер четверти";
Console.WriteLine(result);