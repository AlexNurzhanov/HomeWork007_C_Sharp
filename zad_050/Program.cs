// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//вводим позиции по i и j -> если таких нет - выводим, что позиции не существует. Если есть - выводим элемент по этим индексам.


int[,] FillArray(int row, int column)
{
    int[,] fill = new int[row, column];
    for (int i = 0; i < fill.GetLength(0); i++)
    {
        for (int j = 0; j < fill.GetLength(1); j++)
        {
            fill[i, j] = new Random().Next(10);
        }
    }
    return fill;
}

void PrintArray(int[,] print)
{
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
            Console.Write(print[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] array = FillArray(row, column);
PrintArray(array);

Console.Write("Введите индекс строки элемента, значение которого нужно найти: ");
int i = int.Parse(Console.ReadLine());
Console.Write("Введите индекс столбца элемента, значение которого нужно найти: ");
int j = int.Parse(Console.ReadLine());

if (i >= array.GetLength (0) || j >= array.GetLength (1))
{
    Console.Write("Такого элемента нет в двумерном массиве");
}
else
{
    Console.Write($"Элемент в двумерном массиве с индексом строки {i} и индексом столбца {j} -> {array[i,j]}");
}