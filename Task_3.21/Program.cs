int x1 = 7, y1 = -5, z1 = 0, x2 = 1, y2 = -1, z2 = 9;
double distance;
distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");