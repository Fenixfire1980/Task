// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]З



int[] newArray = new int[8];

for (int i = 0; i < 8; i++)
{
newArray[i] = new Random().Next(1,10);
}
int a = newArray[0];
int b = newArray[1];
int c = newArray[2];
int d = newArray[3];
int e = newArray[4];
int f = newArray[5];
int h = newArray[6];
int s = newArray[7];

Console.Write($"{a},{b},{c},{d},{e},{f},{h},{s} => [{a},{b},{c},{d},{e},{f},{h},{s}]");