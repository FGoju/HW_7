/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void Print(double[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for(int i = 0; i < row_size; i++)
    {
        for(int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
double[,] MassNums(int row, int column, double from, double to)
{
    double[,] arr = new double[row, column];

    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
           // arr [i, j] = Math.Round(new Random().NextDouble() * ((100)- (-100) +  (-100)), 2);
           arr [i, j] = Math.Round(new Random().NextDouble() * (100 - 200) + 50, 2);         
        }        
    }
    return arr;    
}
Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
double[,] arr_1 = MassNums(row, column, -100, 100);
Print(arr_1);
*/

/*
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }
    }
    return arr;
}

string ElementPosition (int[,] arr)
{
    Console.WriteLine ("Введите позицию элемента по горизонтали (номер строки): ");
    int x = int.Parse(Console.ReadLine());

    Console.WriteLine ("Введите позицию элемента по вертикали (номер столбца): ");
    int y = int.Parse(Console.ReadLine());

    if (arr.GetLength(0) < x || arr.GetLength(1) < y)
    {
        return "Такого числа в массиве нет";
    }
    else 
        return $"Это элемент {arr[x-1, y-1]} ";
}

Console.Write("Количество строк в массиве: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов в массиве: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 0, 11);
Print(arr_1);

Console.WriteLine (ElementPosition(arr_1));
*/

/*
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for(int i = 0; i < row_size; i++)
    {
        for(int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }        
    }
    return arr;    
}

void PrintAverage (int[,] arr)
{
    for(int j=0; j<arr.GetLength(1); j++)
    {
        double sum = 0;
        for(int i=0; i<arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];
        }
        Console.WriteLine ($" {Math.Round(sum/arr.GetLength(0), 2)} " );
    }
}


Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 0, 100);
Print(arr_1);

PrintAverage(arr_1);
*/