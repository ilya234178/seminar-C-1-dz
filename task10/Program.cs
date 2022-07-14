// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Ведите трехзначное число: ");

int num = Convert.ToInt32(Console.ReadLine());

int result = secondNumber(num);


Console.WriteLine($"{num} -> {result}");


int secondNumber(int num)
{
     return num / 10 % 10;
}
   
