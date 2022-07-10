/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/



Console.WriteLine("Введите число A");
string number1 = Console.ReadLine();
int numberA = int.Parse(number1);
Console.WriteLine("Введите число B");
string number2 = Console.ReadLine();
int numberB = int.Parse(number2);




int result = 1;
  {
    for(int i=1; i <= numberB; i++)
    result = result * numberA;
  }
  Console.WriteLine(Math.Pow(numberA, numberB));
