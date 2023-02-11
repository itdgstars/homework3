double DistanceAB (int xa, int ya, int za, int xb, int yb, int zb)
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    int deltaZ = za - zb;
    double distAB = Math.Round(Math.Sqrt (deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ),2);
    return distAB;
}
Console.Write("Введите Х координаты точки А ");
int xAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координаты точки А ");
int yAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координаты точки А ");
int zAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Х координаты точки B ");
int xBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координаты точки B ");
int yBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координаты точки B ");
int zBcoord = Convert.ToInt32(Console.ReadLine());


double distanceAB = DistanceAB (xAcoord, yAcoord, zAcoord, xBcoord, yBcoord, zBcoord);
Console.WriteLine("Расстояние между точками А и B " +  distanceAB);
