Console.WriteLine("Введите длинну массива");
int array_str = Convert.ToInt32(Console.ReadLine());
int[] array = new int[array_str];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
}

Console.Write("[ ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ", ");
}
Console.Write("]");
Console.WriteLine(" ");
int j = array.Length - 1;
int[] new_array = new int [array_str / 2];
for (int i = 0; i < array.Length / 2; i++)
{
     new_array[i] = array[i] * array[j] ;
     j--;
}

Console.Write("[ ");
for (int i = 0; i < new_array.Length; i++)
{
    Console.Write(new_array[i] + ", ");
}
Console.Write("]");

