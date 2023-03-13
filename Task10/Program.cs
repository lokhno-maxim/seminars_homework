Console.WriteLine ("Введите ваше число");
int N = Convert.ToInt32(Console.ReadLine());

int number_ostatok = N % 100;
int second_number = number_ostatok / 10;

Console.WriteLine(second_number);