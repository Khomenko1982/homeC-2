// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// Console.Write("Введите число, а я выведу третью цифру этого числа: ");
// int a = Convert.ToInt16(Console.ReadLine());

// if (a<100)
// {
// Console.Write("третьей цифры нет ");

// }
// if (a>100)
// {
//     //int num3 = new Random().Next(100,1000);
//     int num3 = a().Next(100,1000);
//     int num3=(a%10);
    
//   Console.WriteLine(num3);  
// }

Console.Write("Введите число, а я выведу третью цифру этого числа: ");
 int a = Convert.ToInt32(Console.ReadLine());
//Преобразование числа в массив
string str = a.ToString();
int[] b = new int[str.Length];
for( int i=0; i< str.Length; i++)
{
    
    b[i] = int.Parse(str[i].ToString());
  
}
if (b.Length<3)
{
    Console.Write("третьей цифры нет ");
    }
    else
    {
int n3 =b[2];
Console.Write("Третья цифра: ");
     Console.Write(n3);
    }