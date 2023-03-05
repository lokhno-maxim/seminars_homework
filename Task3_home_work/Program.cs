Console.WriteLine ("Введите ваше первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
﻿Console.WriteLine ("Введите ваше второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
﻿Console.WriteLine ("Введите ваше третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if (max < number2)
 { max = number2; }

if (max < number3)
 { max = number3;}

  Console.WriteLine ("максимальное из трех");  
  Console.WriteLine(max);
