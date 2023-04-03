Console.WriteLine("Введите координаты первой точки");

Console.Write("X: ");
int firstX = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int firstY = Convert.ToInt32(Console.ReadLine());

Console.Write("Z: ");
int firstZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");

Console.Write("X: ");
int secondX = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int secondY = Convert.ToInt32(Console.ReadLine());

Console.Write("Z: ");
int secondZ = Convert.ToInt32(Console.ReadLine());

double distance = Distance(firstX, firstY, firstZ, secondX, secondY, secondZ);
double disRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками -> {disRound}");


double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int x = x1 - x2;
    int y = y1 - y2;
    int z = z1 - z2;
    double c = Math.Sqrt(x*x+y*y+z*z);
    return c;
}
