Console.WriteLine ("Введите число");
int count = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= count; i++)
 {
    int result = i * i ;
    Console.Write (result + "\t") ;
 }
