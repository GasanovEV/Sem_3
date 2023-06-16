/*/Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и
Y ≠ 0
//и выдаёт номер четверти плоскости, в которой находится эта точка.*/

Console.Clear();
Console.Write("Введите X: ");
int X = int.Parse(Console.ReadLine());
Console.Write("Введите Y: ");
int Y = int.Parse(Console.ReadLine());
if(X > 0 && Y > 0)
{
    Console.WriteLine("1");
}
else if(X < 0 && Y > 0)
{
    Console.WriteLine("2");
}
else if(X < 0 && Y < 0)
{
    Console.WriteLine("3");
}
else if(X > 0 && Y < 0)
{
    Console.WriteLine("4");
}
else
{
    Console.WriteLine("Ошибка! Точка попадает на оси координат!");
}
