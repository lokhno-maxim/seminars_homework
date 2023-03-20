int[] arr = { 4, 1, 3, 6, 8, 9, 5, 5, 7, 8 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
       Console.Write($"{array[i]}"); 
    }
    Console.WriteLine();
}

void SelectionSort(int [] array)
{
   int count = array.Length;
   for ( int i = 0 ; i < count - 1 ; i++ )
    {
       int maxPosition = i;

       for ( int j = i + 1 ; j < count; j++ )
       {
           if(array[j] > array[maxPosition]) maxPosition = j;
       }

       int temporary = array[i];
       array[i] = array[maxPosition];
       array[maxPosition] = temporary;
    }


}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
