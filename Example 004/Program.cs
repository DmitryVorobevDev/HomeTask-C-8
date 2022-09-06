int[ , , ] getArray(int mLocal, int nLocal, int lLocal)
{
    int[ , , ] result = new int[mLocal, nLocal, lLocal];
    for (int i = 0; i < mLocal; i++)
    {
        for (int j = 0; j < nLocal; j++)
        {
            for (int k = 0; k < lLocal; k++)
            {
                result[i, j, k] = new Random().Next(0, 10);
            }
        }
    }
    return result;
}

void printArray(int[, ,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.WriteLine($"{inArray[i, j, k]} - Индекс  {i}, {j}, {k} ");
            }
        }
    }
}

int m = 2;
int n = 2;
int l = 2;
int[ , , ] array = getArray(m, n, l);
printArray(array);