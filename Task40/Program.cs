// Принимает 3 числа и проверяет могут ли они образовать треугольник.

Console.WriteLine("Введите длинну стороны а =");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длинну стороны b =");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длинну стороны c =");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b+c && b < a+c && c < b+a) Console.WriteLine("Существует вероятность того, что данные длинны сторон могут образовать общий треугольник");
 else Console.WriteLine("НЕТ");
 