// Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Проверяем, является ли второе число кратным первому.");
Console.Write("Введите первое число: ");
int a = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите Второе число: ");
int b = Convert.ToInt16(Console.ReadLine());
//new Random().Next(1,10) ;

if ((a%b)>0)
{
int ostatok=(a%b);
Console.Write("не кратно, остаток ");
Console.Write(ostatok);

}
else
{
  Console.WriteLine("кратно");  
}