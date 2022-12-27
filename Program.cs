Main();

void Main()
{
	bool isWorking = true;
	while (isWorking)
	{
		Console.Write("Input command: ");
		switch (Console.ReadLine())
		{
			case "Task47": Task47(); break;
			case "Task50": Task50(); break;
			case "Task52": Task52(); break;
			case "exit": isWorking = false; break;
		}
		Console.WriteLine();
	}
}

// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
void Task47()
{
    int firstLength = ReadInt("firstLength");
    int secondLength = ReadInt("secondLength");
    double [,] array = GetArray(firstLength, secondLength);
    PrintArray(array);
}

int ReadInt(string argument)
{
	Console.Write($"Input {argument}: ");
	return int.Parse(Console.ReadLine());
}

double [,] GetArray (int length, int secondLength)
{
    double [,] array = new double[length, secondLength]; 
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = random.Next(1, 100) + random.NextDouble();
        }
    }
    return array;
}

void PrintArray (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j],2)}  ");
        }
        Console.WriteLine();
    }
}
//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
void Task52()
{
    int firstLength = ReadInt("firstLength");
    int secondLength = ReadInt("secondLength");
    int [,] arr = GetArr(firstLength, secondLength);
    PrintArr(arr);
    AverageSum(arr);

}
int [,] GetArr (int length, int secondLength)
{
    int [,] arr = new int[length, secondLength]; 
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            arr[i, j] = random.Next(10); 
        }
    }
    return arr;
}

void PrintArr (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void AverageSum (int [,] arr)
{ 
    for (int i = 0; i < arr.GetLength(0); i++)
        {  
            double sum = 0; 
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum = sum+arr[j,i];
            }
            Console.WriteLine(Math.Round(sum/arr.GetLength(1),2));
            
        }
    }
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
void Task50()
{
    int firstLength = ReadInt("firstLength");
    int secondLength = ReadInt("secondLength");
    int indexString = ReadInt("indexString");
    int indexColumn = ReadInt("indexColumn");
    int [,] arr = GetArr(firstLength, secondLength);
    PrintArr(arr);
    ElementArray(arr, indexString, indexColumn);
   
    }
void ElementArray (int [,] arr, int indexString, int indexColumn)
{ if((indexString < arr.GetLength(0)) || (indexColumn < arr.GetLength(1)))
{
            Console.WriteLine($"Element value {arr[indexString,indexColumn]}");
        } 
        else 
        Console.WriteLine($"No such element");
    }