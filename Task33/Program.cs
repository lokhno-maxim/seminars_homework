// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

Console.WriteLine("Введите длинну массива");
int array_str = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите искомое число");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[array_str];
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
int j = 0;
for (int i = 0; i < array_str; i++)
{
    if (array[i] == number) j++;
}

Console.WriteLine(" ");
if (j > 0) Console.WriteLine("Мы его нашли");
else Console.WriteLine("Его там нет");