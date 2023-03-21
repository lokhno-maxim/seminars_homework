
int count = 8;
int[] array = new int[8];
for (int i=0; i < count; i++)
 {
    array[i] = new Random().Next(0,2);
    Console.Write(array[i] + ", " );
 }

