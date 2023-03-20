int TakeDigit(string a)
{
    System.Console.WriteLine(a);
    int result = Int32.Parse(System.Console.ReadLine());
    return result;
}

int[,] CreateRandomDoubleArray(int m, int n)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = Random.Shared.Next(0,10);
        }
    }

    return array;
}

void PrintDoubleArray(int[,] array)
{
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] CreateFormulaMatrix(int m, int n)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = i+j;
        }
    }

    return array;
}

int[,] MatrixOddSquare(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                array[i,j] *= array[i,j];
            }
        }
    }

    return array;
}

int MatrixMainDiagonalSum(int[,] array)
{

    int Result = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j)
            {
                Result += array[i,j];
            }
        }
    }

    return Result;
}



// Task 1 Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
int[,] RandomArray = CreateDoubleArray(TakeDigit("Input m = "), TakeDigit("Input n = "));

PrintDoubleArray(RandomArray);
*/



// Task 2  Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
/* 
int[,] FormulaArray = CreateFormulaMatrix(TakeDigit("Input m = "), TakeDigit("Input n = "));

PrintDoubleArray(FormulaArray);
*/



// Task 3  Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
/*
int[,] RandomArray = CreateRandomDoubleArray(TakeDigit("Input m = "), TakeDigit("Input n = "));

PrintDoubleArray(RandomArray);

RandomArray = MatrixOddSquare(RandomArray);

PrintDoubleArray(RandomArray);
*/

// Task 4 Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*
int[,] RandomArray = CreateRandomDoubleArray(TakeDigit("Input m = "), TakeDigit("Input n = "));

PrintDoubleArray(RandomArray);

int Sum = MatrixMainDiagonalSum(RandomArray);

System.Console.WriteLine("Sum = " + Sum);
*/

