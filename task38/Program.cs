// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
 
double[] arrayRealNum = new double[15];
for (int i = 0; i < arrayRealNum.Length; i++)
{
    arrayRealNum[i] = new Random().Next(1, 40);
    Console.Write(arrayRealNum[i] + " ");
}

double maxNumber = arrayRealNum[0];
double minNumber = arrayRealNum[0];

for (int i = 1; i < arrayRealNum.Length; i++)
{
    if (maxNumber < arrayRealNum[i])
    {
        maxNumber = arrayRealNum[i];
    }
    if (minNumber > arrayRealNum[i])
    {
        minNumber = arrayRealNum[i];
    }
}

double decision = maxNumber - minNumber;

Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");