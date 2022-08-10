// Задача 14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b=7;
int c=23;
if ((a%b|a%c)>0)
{
Console.Write("не кратно ");
}
else
{
  Console.WriteLine("кратно");  
}

