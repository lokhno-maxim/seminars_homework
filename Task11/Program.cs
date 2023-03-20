Random rand = new Random();
int number = rand.Next(100, 1000);
int first_number = number / 100;
int second_number = number % 100;
second_number = second_number % 10;
int result = 10 * first_number + second_number;
Console.WriteLine(number);
Console.WriteLine(result);

