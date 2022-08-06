//  Задайте одномерный массив, заполненный случайными числами.
//   Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Write($"Введи количество элементов массива: ");
int numberCount = Convert.ToInt32(Console.ReadLine());

int RandomNum(int numberCount, int min, int max)
  {
  int[] randomNum = new int[numberCount];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNum.Length; i++ ){
      randomNum[i] = new Random().Next(min, max);

      Console.Write(randomNum[i] + " ");

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNum[i];
      }
    }
  return sumElements;
  }
int randomNum =  RandomNum(numberCount, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNum}");