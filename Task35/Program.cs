int[] array = new int[123];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-999, 1000);
}

Console.Write("[ ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ", ");
}
Console.Write("]");
Console.WriteLine(" ");
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] <= 99)
    j++;
}

Console.WriteLine(" ");
if (j > 0) Console.WriteLine("Мы его нашли " + j + " раз");
else Console.WriteLine("Его там нет");