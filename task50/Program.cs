// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

Console.Write("Введите координаты позиции элемента, разделенных запятой: ");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"m = {m}, n = {n}.");

int[,] array = new int[m, n];
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array )
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3}, ");
            else Console.Write($"{array[i, j],3}]");
        }
        Console.WriteLine();
    }
}
void NumberSearch( int [,] array)
{   
    Console.WriteLine("Введите координаты: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if (a > m || b > n ) Console.WriteLine("Нет этих координат");
    else
    {
        object c = array.GetValue(a, b);
        Console.WriteLine($"Число с координатами {a} , {b} = {c}");
    }
}
int[,] matrixResult = GetMatrix(m, n);
PrintMatrix(matrixResult);
NumberSearch(matrixResult);


// Console.Write("Введите координаты позиции элемента, разделенных запятой: ");
// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Clear();
// Console.WriteLine($"m = {m}, n = {n}.");

// double[,] array = new double[m, n];
// string? positionElement = Console.ReadLine();
// positionElement = RemovingSpaces(positionElement);
// int[] position = ParserString(positionElement);

// if(position[0] <= m 
// && position[1] <= n 
// && position[0] >= 0 
// && position[1] >= 0) 
// {
//   double result = array[position[0]-1, position[1]-1];
//   Console.Write($"Значение элемента: {result}");
// }
// else Console.Write($"такого элемента в массиве нет.");

// int[] ParserString(string input)
// {
//   int countNumbers = 1;
//   for (int i = 0; i < input.Length; i++)
//   {
//       if (input[i] == ',')
//           countNumbers++;
//   }

//   int[] numbers = new int[countNumbers];

//   int numberIndex = 0;
//   for(int i = 0; i < input.Length; i++)
//   {
//     string subString = String.Empty;

//     while (input[i] != ',')
//     {
//       subString += input[i].ToString();
//       if (i >= input.Length - 1)
//         break;
//       i++;
//     }
//     numbers[numberIndex] = Convert.ToInt32(subString);
//     numberIndex++;
//   }

//   return numbers;
// }

// string RemovingSpaces (string input)
// {
//   string output = String.Empty;
//   for (int i = 0; i < input.Length; i++)
//   {
//     if (input[i] != ' ') 
//     {
//       output += input[i];
//     }
//   }
//   return output;
// }