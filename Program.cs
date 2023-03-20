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

void PrintDoubleMatrix(double[,] array)
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

double[,] MatrixRandomDouble(int m, int n)
{
    var rand = new Random();
    double[,] array = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = rand.NextDouble() * 10;
        }
    }

    return array;
}

int FindElementInMatrix(int row, int column, int[,] matrix)
{
    if((row - 1 > matrix.GetLength(0)) || (column - 1 > matrix.GetLength(1)))
    {
        System.Console.WriteLine("Out of Range");
        return 0;
    }
    else
    {
        int Result = matrix[row-1,column-1];
        return Result;
    }

}

double[] AvgInAColumn(int[,] matrix)
{
    double[] Result = new double[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            temp += matrix[i,j];
            Result[i] = (temp / matrix.GetLength(0));
        }
    }

    return Result;
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("Your array = [{0}]", string.Join(", ", array));
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

// Task 5 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] RandomDoubleMatrix = MatrixRandomDouble(TakeDigit("Input m = "), TakeDigit("Input n = "));

PrintDoubleMatrix(RandomDoubleMatrix);
*/

// Task 6 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] RandomMatrix = CreateRandomDoubleArray(TakeDigit("Input rows number = "), TakeDigit("Input columns number = "));

PrintDoubleArray(RandomMatrix);

System.Console.WriteLine("Result = " + FindElementInMatrix(TakeDigit("Input row = "), TakeDigit("Input column = "), RandomMatrix));
*/

// Task 7 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] RandomMatrix = CreateRandomDoubleArray(TakeDigit("Input rows number = "), TakeDigit("Input columns number = "));

PrintDoubleArray(RandomMatrix);

double[] Result = AvgInAColumn(RandomMatrix);

PrintArray(Result);