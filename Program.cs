// Задача 1. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


using System.Xml.XPath;

static string PrintElemArray(int[,] matrix, int i, int j)
{

    string result = "Такого элемента нет! :-(";

    int row = matrix.GetLength(0);  // int row - количяество строк
    int col = matrix.GetLength(1);  // int col - количество столбцов

    if (row > 0 && col > 0)
    {

        if (i < row && j < col)
        {

            result = matrix[i, j].ToString();

        }

    }

    return result;

}

int[,] matrix = {{5, 4, 78, 23, 455}, {3, 6, 7, 3, 6}, {3, 5, 7, 8, 3}};
Console.Write("Введите строку: ");
int i = Convert.ToInt32(Console.ReadLine()); // строка
Console.Write("Введите столбец: ");
int j = Convert.ToInt32(Console.ReadLine()); // столбец

Console.WriteLine(PrintElemArray(matrix, i, j));



//--------------------------------------------------


// Задача 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

Console.WriteLine("Введите размер массива m x n и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}


//----------------------------------------------

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Введите размер m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];

void mas(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{
for (j = 0; j < n; j++)
{
randomArray[i,j] = rand.Next(1,9);
}
}
}

void printm(int[,] array)
{
int i,j;
for (i = 0; i < array.GetLength(0); i++)
{
Console.WriteLine();
for (j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i,j]} ");
}
Console.WriteLine();
}
}

mas(m,n);
Console.WriteLine("\n Исходный массив: ");
printm(randomArray);

// Функция, считающая сумму элементов в строке
int SumLine(int[,] array, int i)
{
int sum = array[i,0];
for (int j = 1; j < array.GetLength(1); j++)
{
sum += array[i,j];
}
return sum;
}

int minSum = 1;
int sum = SumLine(randomArray, 0);
for (int i = 1; i < randomArray.GetLength(0); i++)
{
if (sum > SumLine(randomArray, i))
{
sum = SumLine(randomArray, i);
minSum = i+1;
}
}
Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");