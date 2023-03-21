int Prompt()
{
 Console.WriteLine ("Введите число");
 return Convert.ToInt32(Console.ReadLine());
}
int result = 1;
int Nums(int number)
{
 int i; 
    for (i = 1; i <= number; i++)
    {
      result = result*i;
    }
    return result;
}
int a = Prompt();
Console.WriteLine(Nums(a));