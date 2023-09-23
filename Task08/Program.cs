
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите целое число больше единицы:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 1)
{
    int count = 1;
    while (count <= number)
    {
        if (count % 2 == 0)
        {
            Console.WriteLine(count);
            count = count + 1;
        }
        else
        {
            count = count + 1;
        }
    }

}
else
{
    Console.WriteLine("Не коректный ввод");
}