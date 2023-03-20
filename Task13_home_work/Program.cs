Console.WriteLine ("Введите ваше число");
int number = Convert.ToInt32(Console.ReadLine());
int proverka = number / 100;

if (proverka >= 1 && proverka <=10000)
{   if (proverka >= 1 && proverka <=10)
    
    {
        int result = number % 100;
        result = result % 10;
        Console.WriteLine("Число трёхзначное. 3я цыфра {0}.", result);
    }

    if (proverka >=11 && proverka <= 99)

    { 
        int result = number % 1000;
        result = result % 100;
        result = result / 10;
        Console.WriteLine("Число четырёхзначное. 3я цыфра {0}.", result);
    }

    if (proverka >=100 && proverka <= 999)

    {   int result = number % 10000;
        result = result % 1000;
        result = result / 100;
        Console.WriteLine("Число пятизначное. 3я цыфра {0}.", result);
    }

    if (proverka >= 1000) Console.WriteLine("Программа не предназначена для обработки таких больших чисел.");
}
else if (proverka == 0) Console.WriteLine("Число меньше 100");

