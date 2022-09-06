// 
void SpiralSort(int[,] arr)
{
    int num = 1;
    int i = 0;
    int j = 0;
    while (num <= arr.GetLength(0) * arr.GetLength(1))
    {
        arr[i, j] = num;
        if (i <= j + 1 && i + j < arr.GetLength(0) - 1)
            ++j;
        else if (i < j && i + j >= arr.GetLength(1) - 1)
            ++i;
        else if (i >= j && i + j > arr.GetLength(0) - 1)
            --j;
        else
            --i;
        ++num;
    }
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

int[,] array = new int[4, 4];

SpiralSort(array);
printArray(array);