Console.WriteLine ("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int ostatok;
ostatok = number%2;
switch (ostatok)
{
case 1:
   Console.WriteLine("Число нечетное");
   break;

case 0:
   Console.WriteLine("Число четное");
   break;
}
