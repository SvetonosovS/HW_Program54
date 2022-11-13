// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

static int[,] GetArray(int row, int column, int minRandomValue, int maxRandomValue)
{
    int[,] randomArray = new int[row, column];

    for (int rowIndex = 0; rowIndex < row; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < column; columnIndex++)
        {
            randomArray[rowIndex, columnIndex] = new Random().Next(minRandomValue, maxRandomValue);
        }
    }
    return randomArray;
}

static void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row, column]} ");
        }
        Console.WriteLine();
    }
}


static void SortingArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int cycle = 0; cycle < array.GetLength(1); cycle++)
        {
            for (int j = 0; j < array.GetLength(1) - 1 - cycle; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }
        }
    }
}



Console.Clear();
int row = new Random().Next(1, 10);
int column = new Random().Next(1, 10);
int minRandomValue = new Random().Next(-9, 0);
int maxRandomValue = new Random().Next(0, 10);
int[,] array = GetArray(row, column, minRandomValue, maxRandomValue);

PrintArray(array);

Console.WriteLine();

SortingArray(array);
PrintArray(array);