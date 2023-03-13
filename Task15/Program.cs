Console.WriteLine ("Введите ваше число");
int number1 = Convert.ToInt32(Console.ReadLine());

switch (number1) 
{
  case 1:
   Console.WriteLine("НЕТ.Понедельник это будний день.");
   break;
  
  case 2:
   Console.WriteLine("НЕТ.Вторник это будний день.");
  break;
  
  case 3:
   Console.WriteLine("НЕТ.Среда это будний день.");
  break;

  case 4:
   Console.WriteLine("НЕТ.Четверг это будний день.");
  break;

  case 5:
   Console.WriteLine("НЕТ.Пятница это будний день.");
  break;

  case 6:
   Console.WriteLine("ДА.Суббота это выходной день.");
  break;

  case 7:
   Console.WriteLine("ДА.Воскресенье это выодной день.");
  break;

  default:
   Console.WriteLine("Incorrect version");
break;
}
