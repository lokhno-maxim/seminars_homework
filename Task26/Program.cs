int Prompt()
{
 Console.WriteLine ("Введите число");
 return Convert.ToInt32(Console.ReadLine());
}

int SumNums(int number)
{
    int i = 0;
    while (number > 0)
    {
        number = number / 10;
        i = i + 1 ;
    } 
      return i;
}
int a = Prompt();
Console.WriteLine(SumNums(a));
    