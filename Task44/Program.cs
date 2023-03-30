

Console.WriteLine("Введите число N=");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
array[0] = 0; array[1] = 1;
int tmp; tmp = array[0];


for (int i = 2; i < n; i++)
{
    tmp = array[i - 2] + array[i - 1];
    array[i] = tmp;
}

for (int i = 0; i < n; i++)
{
    Console.Write(array[i] + " ");
}