// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] GetArray( int m, int n)
// {
//     int[,] matrix = new int[m,n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(11);
//         }
//     }
//     return matrix;
// }
// int[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// void PrintArray(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int m = 0; m < inputMatrix.GetLength(1); m++)
//         {
//             Console.Write(inputMatrix[i,m] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] ReplaceRows(int[,] replacableMatrix)
// {
//     for (int i = 0; i < replacableMatrix.GetLength(1); i++)
//     {
//         int temp = replacableMatrix[0,i];
//         replacableMatrix[0, i] = replacableMatrix[replacableMatrix.GetLength(0) - 1, i];
//         replacableMatrix[replacableMatrix.GetLength(0) -1 , i] = temp;
//         Console.WriteLine();
//     }
//     return replacableMatrix;
// }
// int[,] replacedMatrix = ReplaceRows(resultMatrix);
// PrintArray(replacedMatrix);

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] GetArray( int m, int n)
// {
//     int[,] matrix = new int[m,n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(11);
//         }
//     }
//     return matrix;
// }
// int[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// void PrintArray(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int m = 0; m < inputMatrix.GetLength(1); m++)
//         {
//             Console.Write(inputMatrix[i,m] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] ReplaceRowsColumns(int[,] replacableMatrix)
// {
//     int rowCount = replacableMatrix.GetLength(0);
//     int columnCount = replacableMatrix.GetLength(1);
//     int[,] result = new int[rowCount, columnCount];
//     for (int i = 0; i < rowCount; i++)
//     {
        
//         for (int j = 0; j < columnCount; j++)
//         {
//             result[j,i] = replacableMatrix[i,j];
//         }
        
//     }
//     return result;
// }
// Console.WriteLine();
// if ( rows == columns)
// {
//     int[,] replacedMatrix = ReplaceRowsColumns(resultMatrix);
//     PrintArray(replacedMatrix);
// }
// else Console.WriteLine("Операция замены строк на столбцы возможно только в массиве с одинаковым количеством столбцов и срок");

// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] GetArray( int m, int n)
// {
//     int[,] matrix = new int[m,n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(11);
//         }
//     }
//     return matrix;
// }
// int[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// void PrintArray(int[,] inputMatrix)
// {
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         for (int m = 0; m < inputMatrix.GetLength(1); m++)
//         {
//             Console.Write(inputMatrix[i,m] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] SearchAndDeleteMin(int[,] inputMatrix)
// {
//     int rowMin = 0;
//     int columnMin = 0;
//     int minElement = int.MaxValue;
//     for (int i = 0; i < inputMatrix.GetLength(0); i++)
//     {
//         if (rowMin != i)
//         {
//             for (int j = 0; j < inputMatrix.GetLength(1); j++)
//             {
//                 if (columnMin != j)
//                 {
//                     if (inputMatrix[i,j] < minElement) minElement = inputMatrix[i,j];
//                 }
//             }
//         }
//     }
//     int[,] result = new int[inputMatrix.GetLength(0),inputMatrix.GetLength(1)];
    
// }

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] GetArray( int m, int n)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(11);
        }
    }
    return matrix;
}
int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            Console.Write(inputMatrix[i,m] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] SortArray(int[,] matrixToSort)
{
    for (int i = 0; i < matrixToSort.GetLength(0); i++)
    {
        int sorted = 0;
        for (int m = 0; m < matrixToSort.GetLength(1) - 1; m++)
        {
            for (int n = 0; n < matrixToSort.GetLength(1) - sorted - 1; n++)
            {
                if(matrixToSort[i,n] < matrixToSort[i, n+1] )
                {
                    int temp = matrixToSort[i,m];
                    matrixToSort[i,n] = matrixToSort[i,n+1];
                    matrixToSort[i,n + 1] = temp;
                } 
            }
            sorted++;            
        }                
    }
        Console.WriteLine();
    return matrixToSort;
}

PrintArray(SortArray(resultMatrix));

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] GetArray( int m, int n)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(11);
        }
    }
    return matrix;
}
void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            Console.Write(inputMatrix[i,m] + "\t");
        }
        Console.WriteLine();
    }
}
int StringMinSumm(int[,] inputMatrix)
{
    int[] summMatrix = new int[inputMatrix.GetLength(0)];
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            summ = summ + inputMatrix[i,j];
        }
        summMatrix[i] = summ;
    }
    int minString = 0;
    for (int i = 0; i < summMatrix.Length; i++)
    {
        if (summMatrix[i] < summMatrix[minString]) minString = i;
    }
    return minString; 
}
if ( rows != columns)
{
    int[,] resultMatrix = GetArray(rows, columns);
    PrintArray(resultMatrix);
    Console.WriteLine("В заданной матрице наименьшая сумма элементов находится в строке с индексом " + StringMinSumm(resultMatrix));
} 
else 
{
    Console.WriteLine("Количество строк не должно равняться количеству столбцов. Задайте количество строк и столбцов заново");
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк первой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк второй матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
if ( columns1 != rows2) Console.WriteLine("Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы. При текущих данных операция умножения невозможна.");
else
{
    int[,] resultMatrix1 = GetArray(rows1, columns1);
    int[,] resultMatrix2 = GetArray(rows2, columns2);
    PrintArray(resultMatrix1);
    PrintArray(resultMatrix2);
    Console.WriteLine("Матрица, получившаяся в результате умножения: ");
    PrintArray(MatrixMultiply(resultMatrix1,resultMatrix2));
}
int[,] GetArray( int m, int n)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(11);
        }
    }
    return matrix;
}
void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            Console.Write(inputMatrix[i,m] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] MatrixMultiply (int[,] inputMatrix1, int[,] inputMatrix2)
{
    int [,] resultMAtrix = new int[inputMatrix1.GetLength(0),inputMatrix1.GetLength(0)];
    for (int i = 0; i < inputMatrix1.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix1.GetLength(0); j++)
        {
            int res = 0;
            for (int k = 0; k < inputMatrix1.GetLength(1); k++)
            {
                res = res + inputMatrix1[i,k] * inputMatrix2[k,j];
            }
            resultMAtrix[i,j] = res;
        }
    }
    return resultMAtrix;
}

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите глубину массива( третье измерение): ");
int depth = Convert.ToInt32(Console.ReadLine());
int[,,] GetArray( int m, int n, int p)
{
    int[,,] matrix = new int[m,n,p];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = new Random().Next(10,100);
            }            
        }
    }
    return matrix;
}
int[,,] resultMatrix = GetArray(rows, columns, depth);
PrintArray(resultMatrix);
void PrintArray(int[,,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            for (int n = 0; n < inputMatrix.GetLength(2); n++)
            {
                Console.Write($"{inputMatrix[i,m,n]}({i},{m},{n}) ");
            }
            Console.WriteLine();            
        }        
    }
}


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите количество строк квадратного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            Console.Write(inputMatrix[i,m] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] MatrixSpiral (int n)
{
    int [,] resultMAtrix = new int[n,n];
    for (int currChar = 1, padding = 0; padding < n/2; padding++)
    {
        for (int j = padding; j < n - padding; j++)
        {
            resultMAtrix[padding,j] = currChar;
        }
        for (int j = padding; j < n - padding; j++)
        {
            resultMAtrix[n - padding - 1,j] = currChar;
        }
         for (int i = padding + 2; i < n - padding - 1; i++)
        {
            resultMAtrix[i,padding] = currChar;
        }
        for (int i = padding + 1; i < n - padding - 1; i++)
        {
            resultMAtrix[i,n - padding - 1] = currChar;
        }
        currChar = 1 - currChar;
        resultMAtrix[padding + 1,padding] = currChar;
    }
    if (n%2 != 0  && resultMAtrix[0,0] == 1) resultMAtrix[n/2,n/2] = 1;
    return resultMAtrix;
}
PrintArray(MatrixSpiral(n));