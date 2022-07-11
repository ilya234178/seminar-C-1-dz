// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8




Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 <= 1)
{
  Console.WriteLine("Число нужно целое больше 1: ");
}
else
{
  for (int i = 1; i <= num1; i++)
  {
    if (i % 2 == 0)
    {
      Console.WriteLine($" {i}");

    }
  }
}



