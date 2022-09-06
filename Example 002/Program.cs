//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] getArray(int mLocal, int nLocal)
{
    int[,] result = new int[mLocal, nLocal];
    for (int i = 0; i < mLocal; i++)
    {
        for (int j = 0; j < nLocal; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void printArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumRowFunction (int [,] array, int i)
{
  int sumRow1 = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumRow1 += array[i,j];
  }
  return sumRow1;
}

int rows = 5;
int columns = 3;
int[,] array = getArray(rows, columns);
printArray(array);
int minSumRow = 0;
int sumRow = SumRowFunction(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumRow = SumRowFunction(array, i);
  if (sumRow > tempSumRow)
  {
    sumRow = tempSumRow;
    minSumRow = i;
  }
}

Console.WriteLine($"{minSumRow+1} - строка с наименьшей суммой элементов");


