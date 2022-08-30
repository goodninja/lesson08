// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine($"\nНеобходимо установить размер массива (m x n) и диапазон случайных значений");
int m = InputNumbers("Введите значение m для массива: ");
int n = InputNumbers("Введите значение n для массива: ");
int range = InputNumbers("Введите диапазон для случайных значений: от 1 до ");

int[,] Array = new int[m, n];
CreateArray(Array);
WriteArray(Array);

Console.WriteLine($"\nОтсортированный массив: ");
MakeOrderArrayLines(Array);
WriteArray(Array);

void MakeOrderArrayLines(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(1) - 1; k++)
            {
                if (Array[i, k] < Array[i, k + 1])
                {
                    int temp = Array[i, k + 1];
                    Array[i, k + 1] = Array[i, k];
                    Array[i, k] = temp;
                }
            }
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
