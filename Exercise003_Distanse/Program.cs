Console.Clear();
Console.Write("Введите x точки А: ");
double dotAx = double.Parse(Console.ReadLine()??"");
Console.Write("Введите y точки A: ");
double dotAy = double.Parse(Console.ReadLine()??"");
Console.Write("Введите x точки B: ");
double dotBx = double.Parse(Console.ReadLine()??"");
Console.Write("Введите y точки B: ");
double  dotBy = double.Parse(Console.ReadLine()??"");

double distanse = Math.Sqrt((dotBx-dotAx)*(dotBx-dotAx)+(dotBy-dotAy)*(dotBy-dotAy));

Console.WriteLine ($"{distanse:f2}");