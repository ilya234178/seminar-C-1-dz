// Задача 58: Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.

//формула умножения матрицы A(1 2 3)
//                           (4 5 6)
//                            *
 //                        B(1 2 3)
//                          (4 5 6)
//                          (7 8 9)

//(A1*B1)+(A2*B4)+(A3*B7)         (A4*B1)+(A5*B4)+(A6*B7)
//(A1*B2)+(A2*B5)+(A3*B8)         (A4*B2)+(A5*B5)+(A6*B8)
//(A1*B3)+(A2*B6)+(A3*B9)         (A4*B3)+(A5*B6)+(A6*B9)



Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
PrintMatrix(firstMartrix);

int[,] secomdMartrix = new int[n, p];              
CreateArray(secomdMartrix);                        
Console.WriteLine($"\nВторая матрица:");         
PrintMatrix(secomdMartrix);                                                
                                                                             
int[,] resultMatrix = new int[m,p];         
                                            
MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintMatrix(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
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