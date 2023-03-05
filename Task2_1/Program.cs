Random rand = new Random();
int number = rand.Next(10,100);
Console.WriteLine(number);
int max = number / 10;
int min = number % 10;
if (max > min)
Console.WriteLine("Наибольшее цифра числа это {0}", max);
else Console.WriteLine("Наибольшее цифра числа это {0}", min);