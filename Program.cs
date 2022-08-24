//  Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/* 
Console.WriteLine("Введите трехзначное число");
int Number = Convert.ToInt32(Console.ReadLine());
string indexText = Convert.ToString(Number);
if (indexText.Length < 3 || indexText.Length > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine("Вторая цифра"+" "+indexText[1]); ;
} 
*/


//  Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/* 
Console.Write("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string indexText = Convert.ToString(Number);
if (indexText.Length > 2){
  Console.WriteLine("Третья цифра"+" "+ indexText[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
}
 */


//  Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingDay (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Это выходной день");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Нет такого дня недели");
  }
  else Console.WriteLine("Это не выходной день");
}

CheckingDay(dayNumber); 