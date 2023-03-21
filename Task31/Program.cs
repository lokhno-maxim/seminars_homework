// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int count = 12;
int[] array = new int[12];
 for (int i=0; i < count; i++)
 {
    array[i] = new Random().Next(-9,10);
 }
int negative_sum = 0;
int positive_sum = 0;
 for (int i=0; i < count; i++)
 {
    if (array[i] < 0) negative_sum = negative_sum - array[i];
    else positive_sum = positive_sum + array[i];
 }
Console.Write("[ ");
foreach (int el in array)
{
    Console.Write(array[i] + ", ");
}
Console.Write("]");
Console.WriteLine(" ");
Console.WriteLine("Сумма положительных " + (positive_sum));
Console.WriteLine("Сумма отрицательных " + (negative_sum));
