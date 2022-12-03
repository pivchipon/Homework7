/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

/*double [,] GetRandomArray (int rows, int columns, int deviation)
{
double[,] array = new double[rows, columns];
for (int i = 0; i < rows; i++)
    {
for (int j = 0; j < columns; j++)
        {
array[i,j] = new Random().Next(-deviation, deviation + 1);
        }
    }
return array;
}

void PrintArray (double[,] array)
{
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
    {
for (int j = 0; j < array.GetLength(1); j++)
        {
Console.Write(array[i, j] + "\t");
        }
Console.WriteLine();
    }
}

double[,] array = GetRandomArray(5,6,1000);
PrintArray(array);*/


/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/


/*Console.WriteLine("Enter the row's number");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the column's number");
int B = Convert.ToInt32(Console.ReadLine());

int [,] numbers = new int [5,5];

FillArrayRandomNumbers(numbers);

if (A > numbers.GetLength(0) || B > numbers.GetLength(1))
{
Console.WriteLine("There is no such an element");
}
else
{
Console.WriteLine($"значение элемента {A} строки и {B} столбца равно {numbers[A-1,B-1]}");
}

Console.WriteLine();

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
for (int j = 0; j < array.GetLength(1); j++)
        {
array [i,j] = new Random().Next(1, 1500);
        }
    }
}


void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
Console.Write("[ ");
for (int j = 0; j < array.GetLength(1); j++)
        {   
Console.Write(array[i,j] + " ");
        }
Console.Write("]");
Console.WriteLine("");
    }
}

Console.WriteLine();*/


/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


Console.WriteLine("Enter the number of rows");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of columns");
int B = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[A, B];

Console.WriteLine();
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double AvarageNumbers = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        AvarageNumbers = (AvarageNumbers + numbers[i, j]);
    }
    AvarageNumbers = AvarageNumbers/ A;
    Console.Write(AvarageNumbers + "; ");
    Console.WriteLine();
}

Console.WriteLine();
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}