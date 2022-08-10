// Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Write("случайное трёхзначное число: ");
int num3 = new Random().Next(100,1000);
Console.Write(num3);
Console.WriteLine(", удаляем вторую цифру этого числа и получаем");
int a=(num3/100);
int b=(num3%10);
Console.Write(a);
Console.Write(b);
 //int a = Convert.ToInt32(Console.ReadLine());
// int b=(a%100);
// Console.WriteLine(b/10);