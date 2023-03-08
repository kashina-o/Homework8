// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int Input(string msg)
{
  bool flag = false;
  int value = 0;
  while (!flag)
  {
    Console.Write(msg + " ");
    flag = int.TryParse(Console.ReadLine(), out value);
  }
  return value;
}

int[,] CreateArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    return matrix;
}

void FillRandommatrix(int[,] matrix, int min, int max)
{
int row = matrix.GetLength(0);
int columns = matrix.GetLength(1);
for (int i = 0; i < row; i++)
    {
    for (int j = 0; j < columns; j++)
    {
      matrix[i, j] = new Random().Next(min, max);
    }
    }
}

string Print(int[,] matrix)
{
string result = string.Empty;
int row = matrix.GetLength(0);
int columns = matrix.GetLength(1);
    for (int i = 0; i < row; i++)
    {
      for (int j = 0; j < columns; j++)
      {
        result += $"{matrix[i, j],5} ";
      }
      result += "\n";
    }
return result;
}

void MinSumElementsOfRow(int[,] matrix)
{
int minSumRow = 0;
int sumRow = 0;
int result = 0;
for (int i = 0; i < matrix.GetLength(1); i++)
{
    minSumRow += matrix[0, i];
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++) 
    sumRow += matrix[i, j];
    if (sumRow < minSumRow)
    {
        minSumRow = sumRow;
        result = i;
    }
    sumRow = 0;
}
Console.Write($"Cтрока с наименьшей суммой элементов: {result + 1} строка");
}

int a = Input("Введите количество строк: ");
int b = Input("Введите количество столбцов: ");
int min = Input("Введите минимальное значение диапозона: ");
int max = Input("Введите максимальное значение диапозона: ");
int[,] matrix = CreateArray(a, b);
FillRandommatrix(matrix,min,max);
Console.WriteLine(Print(matrix));
MinSumElementsOfRow(matrix);