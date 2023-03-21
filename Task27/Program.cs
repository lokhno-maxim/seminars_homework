int Prompt()
{
 Console.WriteLine ("Введите число");
 return Convert.ToInt32(Console.ReadLine());
}
int number;
int work_number;
int result; result = 0;

number = Prompt();

while (number > 0)
 {
    work_number = number % 10;
    result = result + work_number;
    number /= 10;
 }
     

Console.WriteLine(result);     

 