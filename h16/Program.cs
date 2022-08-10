// Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Проверяем, является ли одно число квадратом другого.");
Console.Write("Введите первое число: ");
int a = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите Второе число: ");
int b = Convert.ToInt16(Console.ReadLine());
//new Random().Next(1,10) ;

if ((a*a)==b|(b*b)==a)
{
//int ostatok=(a%b);
Console.Write("да ");
//Console.Write(ostatok);

}
else
{
  Console.WriteLine("нет");  
}