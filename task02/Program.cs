// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine($"\nНеобходимо установить размер массива (m x n) и диапазон случайных значений");
int m = InputNumbers("Введите m для массива: ");
int n = InputNumbers("Введите n для массива: ");
int range = InputNumbers("Введите диапазон для случайных значений: от 1 до ");

int[,] Array = new int[m, n];
CreateArray(Array);
WriteArray(Array);

int minSumLine = 0;
int sumLine = SumElements(Array, 0);
for (int i = 1; i < Array.GetLength(0); i++)
{
    int tempSumLine = SumElements(Array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"\n{minSumLine + 1} - это строкa с наименьшей суммой элементов, сумма элементов в ней = ({sumLine})");


int SumElements(int[,] Array, int i)
{
    int sumLine = Array[i, 0];
    for (int j = 1; j < Array.GetLength(1); j++)
    {
        sumLine += Array[i, j];
    }
    return sumLine;
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
