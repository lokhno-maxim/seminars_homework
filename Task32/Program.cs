

// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.


Console.WriteLine("Введите длинну массива");
int array_str = Convert.ToInt32(Console.ReadLine());


int[] array = new int [array_str];
for (int i = 0; i < array_str; i++)
{
    array[i] = new Random().Next(-9, 10);
}

Console.Write("[ ");
for (int i = 0; i < array_str; i++)
{
    Console.Write(array[i] + ", ");
}
Console.Write("]");
Console.WriteLine(" ");

for (int i = 0; i < array_str; i++)
{
    if (array[i] < 0) array[i] = -1 * array[i];
    else array[i] = -1 * array[i];
}
Console.Write("[ ");
for (int i = 0; i < array_str; i++)
{
    Console.Write(array[i] + ", ");
}
Console.Write("]");
Console.WriteLine(" ");
