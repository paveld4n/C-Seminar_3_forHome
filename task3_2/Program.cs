// Получить две точки и найти расстояние между ними в 2D
Console.WriteLine("Введите координаты первой точки: ");
bool isPointAX = int.TryParse(Console.ReadLine(), out int ax);
bool isPointAY = int.TryParse(Console.ReadLine(), out int ay);

Console.WriteLine("Введите координаты второй точки: ");
bool isPointBX = int.TryParse(Console.ReadLine(), out int bx);
bool isPointBY = int.TryParse(Console.ReadLine(), out int by);

if(!isPointAX || !isPointAY || !isPointBX || !isPointBY)
{
    Console.WriteLine("Ошибка! Ввели не то. переВВедите.");
    return;
}

double Res = Distance(ax, ay, bx, by);
Console.WriteLine($"Расстояние между точками = {Res}");

double Distance(int x1, int y1, int x2, int y2)
{
    double dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    return dist;
}