/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/



Console.WriteLine("Введите число ");
string number = Console.ReadLine();
int number1 = int.Parse(number); 
int Sumnumber = 0;


  while (number1 > 0)

  {
  Sumnumber = Sumnumber + number1%10;
   number1 = number1/10;
}

Console.WriteLine($"Сумма в числе {number} равна {Sumnumber}");

  