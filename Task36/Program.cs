Console.WriteLine("Введите длинну массива");
int array_str = Convert.ToInt32(Console.ReadLine());

int[] array = new int[array_str];
for (int i = 0; i < array_str; i++)
{
    array[i] = new Random().Next(-99, 100);
}

Console.Write("[ ");
for (int i = 0; i < array_str; i++)
{
    Console.Write(array[i] + ", ");
}
Console.Write("]");
Console.WriteLine(" ");

int result = 0;
for (int i = 0; i < array_str; i=i+2)
{
    result = array[i] + result;
    
}

Console.WriteLine(" ");
Console.WriteLine("Сумма элементов на нечетных позициях " + result);
