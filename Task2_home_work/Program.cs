﻿Console.WriteLine ("Введите ваше первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
﻿Console.WriteLine ("Введите ваше второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if (max > number2)
 { 
  Console.WriteLine ("максимальное из двух");
  Console.WriteLine(max);
 } 
else if(max < number2)
 { 
  Console.WriteLine ("максимальное из двух");  
  Console.WriteLine(number2);
 }

