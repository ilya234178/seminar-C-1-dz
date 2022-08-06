// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу,которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.Clear();
int[] numbers = new int[6];

int[] CreateArrayRndInd(int[] array, int min, int max)
{
    
    
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}
int QuantityPositive(int[] array){
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 0)
    {
      quantity++;
    }
  }
  return quantity;
}

int[] array = CreateArrayRndInd(numbers, 100, 1000);
PrintArray(numbers);
Console.WriteLine();

int quantity = QuantityPositive(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");

