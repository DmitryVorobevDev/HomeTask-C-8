// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] changeArray(int [,] arrayToChange)
{
    for (int i = 0; i < arrayToChange.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToChange.GetLength(1); j++)
        {
            for (int t = 0; t < arrayToChange.GetLength(1) - 1; t++)
            {
                if (arrayToChange[i, t] < arrayToChange[i, t + 1])
                {
                    int temp = arrayToChange[i, t + 1];
                    arrayToChange[i, t + 1] = arrayToChange[i, t];
                    arrayToChange[i, t] = temp;
                }
            }
        }
    }
    return arrayToChange;
}

int rows = 5;
int columns = 5;
int[,] array1 = getArray(rows, columns);
printArray(array1);
Console.WriteLine();
printArray(changeArray(array1));
