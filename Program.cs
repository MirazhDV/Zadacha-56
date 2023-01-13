// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
}

void GetSumLine(int[,] matrix)
{
    int minLine = 0;
    int sumMin = 0;
    int sumLine = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sumMin += matrix[0,i]; 
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sumLine += matrix[i, j];
        {            
            if (sumMin > sumLine)
            {
                sumMin = sumLine;
                minLine = i;
            }
            sumLine = 0;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов '{sumMin}': {minLine + 1} строка.");
    
}

int line = 4;
int column = 4;

int[,] matrix = InitMatrix(line, column);
PrintMatrix(matrix);
Console.WriteLine();
GetSumLine(matrix);