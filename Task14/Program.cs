Console.WriteLine ("Введите два числа. Первое");
int first_number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе.");
int second_number = Convert.ToInt32(Console.ReadLine());
int result = first_number % second_number;
if (result == 0)
Console.WriteLine("Первоче число {0} кратно второму {1}", first_number , second_number);
else Console.WriteLine("Числа {0} и {1} не кратны", first_number , second_number);
