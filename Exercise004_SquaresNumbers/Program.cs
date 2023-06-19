Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()??"");

int count = 1;

while (count<=number)
{
int Pow = count*count;
Console.Write ($"{Pow}, ");

count = count+1;



}
