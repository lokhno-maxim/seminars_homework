Console.WriteLine ("Введите число a=");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число b=");
int b = Convert.ToInt32(Console.ReadLine());
int result = a;
for (int i = 1; i < b; i++)
 {
    result = result * a ;
 }
 Console.Write (result) ;