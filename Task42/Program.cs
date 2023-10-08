// Напишите программу которая будет преобразовывать десятичное число в двоичное
// 46 -> 101110
// 13 -> 1101
// 2 -> 10



int UserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


// string DecimalToBinary(int number)
// {
//     string result = String.Empty;

//     while (number !=0)
//     {
//         result = number % 2 + result;
//         number /= 2;
//     }
//     return result;
// }
 int DecimalToBinary(int number, int baseNum)
 {
 int result = 0;
 int mult = 1;

    while (number > 0)
    {
        result = (number % baseNum) * mult + result;
        mult *= 10;
        number /= 2;
    }
    return result;
}

int num = UserInput("Введите десятичное число");
int baseNumber = UserInput("Введите base число");
int bin = DecimalToBinary(num, baseNumber);
Console.WriteLine($"{num} -> {bin}");
