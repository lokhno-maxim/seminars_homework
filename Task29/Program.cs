int count = 8;
int[] array = new int[8];
Console.Write("[ ");
for (int i=0; i < count; i++)
 {
    array[i] = new Random().Next(0,999999999);
    Console.Write(array[i]  + ", ");
 }
Console.Write("]");