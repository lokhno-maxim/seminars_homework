Console.WriteLine("Введите длинну массива");
int array_str = Convert.ToInt32(Console.ReadLine());

int[] array = new int[array_str];
for (int i = 0; i < array_str; i++)
{
    array[i] = new Random().Next(100, 1000);
}

Console.Write("[ ");
for (int i = 0; i < array_str; i++)
{
    Console.Write(array[i] + ", ");
}
Console.Write("]");
Console.WriteLine(" ");
int j = 0;
for (int i = 0; i < array_str; i++)
{
    if (array[i] % 2 == 0) j++;
}

Console.WriteLine(" ");
if (j > 0) Console.WriteLine("Количество четных чисел " + j);
else Console.WriteLine("Четных чисел не обнаружено");