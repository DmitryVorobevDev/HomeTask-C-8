// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] sumArray(int [,] array1Sum, int [,] array2Sum, int [,] array3Sum)
{
    for (int i = 0; i < array1Sum.GetLength(0); i++)
    {
        for (int j = 0; j < array1Sum.GetLength(1); j++)
        {
            array3Sum [i,j] = array1Sum [i,j] * array2Sum [i,j];
        }  
    }
    return array3Sum;
}


int rows = 3;
int columns = 3;
int[,] array1 = getArray(rows, columns);
int[,] array2 = getArray(rows, columns);
int[,] array3 = getArray(rows, columns);

printArray(array1);
Console.WriteLine();
printArray(array2);
Console.WriteLine();
printArray(sumArray(array1, array2, array3));



