Console.WriteLine("Введите длинну массива");
int array_str = Convert.ToInt32(Console.ReadLine());

float[] array = new float[array_str];
for (int i = 0; i < array_str; i++)
{
    array[i] = new Random().Next(0, 100);
}

Console.Write("[ ");
for (int i = 0; i < array_str; i++)
{
    Console.Write(array[i] + ", ");
}
Console.Write("]");
Console.WriteLine(" ");
float min; float max;
float result = 0;
min = max = array[0];
for (int i = 0; i < array_str; i++)
{
   if (min > array[i]) min = array[i];
   if (max < array[i]) max = array[i];
    
}
result = max - min;
Console.WriteLine(" ");
Console.WriteLine("Разность между max && min = " + result);
