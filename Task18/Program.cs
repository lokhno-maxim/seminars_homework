Console.WriteLine ("Введите квадрант");
int number = Convert.ToInt32(Console.ReadLine());
switch (number) 
{
  case 1:
   Console.WriteLine("x э (0 , +бесконечность)");
   Console.WriteLine("y э (0 , +бесконечность)");
   break;
  
  case 2:
   Console.WriteLine("x э (-бесконечность , 0)");
   Console.WriteLine("y э (0 , +бесконечность)");
  break;
  
  case 3:
   Console.WriteLine("x э (-бесконечность , 0)");
   Console.WriteLine("y э (-бесконечность , 0)");
  break;

  case 4:
   Console.WriteLine("x э (0 , +бесконечность)");
   Console.WriteLine("y э (-бесконечность , 0)");
  break;

default:
   Console.WriteLine("Введите число от 1 до 4.");
   break;
}

