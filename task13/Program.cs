// Задача 13: Напишите программу, которая выводит третью цифру
//  заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}

// выводим второе число

// Console.Clear(); // очистка терминала
// Console.WriteLine("Введите трехзначное число: "); // запрашивает 3 числа
// int numberOne = Convert.ToInt32(Console.ReadLine()); // поле для ввода
// double SecondDigit(int number) //присваеваем 2 числу переменную
// {
//   double resultSecond = 1; // присваеваем в случае, ввода меньше 3 чисел
//   if (number < 100 || number > 999) // проверка на ввод 3 числе
//   {
//     Console.WriteLine("Error: Введите трехзначное число"); // вывод в случае, если ввел меньше 
//   }
//   else{
//     double result = number / 10; //сдвигаемся ко 2 целому числучислу
//     resultSecond = Math.Round(result, 1) % 10; 
//   }
//   return resultSecond; // возвращаем нужное число
// }
// Console.WriteLine(SecondDigit(numberOne)); // выводим второе число
// Переделать как разберешься