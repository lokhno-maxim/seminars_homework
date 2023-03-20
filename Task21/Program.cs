Console.WriteLine ("Введите координаты x первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координаты x второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите координаты y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

float result = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
Console.WriteLine(MathF.Sqrt(result));