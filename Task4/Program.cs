﻿
int[,] FillArraySpiral(int n, int b)
{
    int[,] result = new int[n, b];
    int columns = result.GetLength(1);
    int rows = result.GetLength(0);
    int value = 1;
    for (int i = 0; value <= n * b; i++)
    {
        if (value <= n * b)
        {
            for (int j = i; j < columns - i; j++)
            {
                result[i, j] = value;
                value++;
            }
        }
        if (value <= n * b)
        {
            for (int k = i + 1; k < rows - i; k++)
            {
                result[k, columns - (1 + i)] = value;
                value++;
            }
        }
        if (value <= n * b)
        {
            for (int m = columns - (2 + i); m >= i; m--)
            {
                result[rows - (1 + i), m] = value;
                value++;
            }
        }
        if (value <= n * b)
        {
            for (int s = rows - (2 + i); s >= i + 1; s--)
            {
                result[s, i] = value;
                value++;
            }
        }
    }
    return result;
}

void Show2dArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter the number of rows in the array");
int rows = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter the number of elements in the array row");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] myArr = FillArraySpiral(rows, columns);

Show2dArray(myArr);