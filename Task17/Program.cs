﻿

int Quater(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

Console.WriteLine("Введите координаты точки");
Console.Write("x: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quater = Quater(xCoordinate, yCoordinate);

string result = quater > 0 
        ? $"Указанные координаты соответствуют четверти {quater}"
        : "Введены некоректные координаты";
Console.WriteLine(result);

