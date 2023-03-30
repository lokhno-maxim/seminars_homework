Console.WriteLine("Введите длинну массива");
int array_str = Convert.ToInt32(Console.ReadLine());

int [] array = new int[array_str];
int [] copied_array = new int [array_str];
for (int i = 0; i < array_str; i++)
{
    array[i] = new Random().Next(0, 100);
}

Console.Write("First array = [ ");
for (int i = 0; i < array_str; i++)
{
    Console.Write(array[i] + ", ");
    copied_array[i] = array[i];
}
Console.Write("]");
Console.WriteLine(" ");


Console.Write("Copied array = [ ");
for (int i = 0; i < array_str; i++)
{
    Console.Write(copied_array[i] + ", ");
}
Console.Write("]");
Console.WriteLine(" ");
