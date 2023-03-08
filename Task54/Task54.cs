// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

void SortRowsOfMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < matrix.GetLength(1) - 1; z++)
        {
            if (matrix[i, z] < matrix[i, z + 1])
            {
                int temp = 0;
                temp = matrix[i, z];
                matrix[i, z] = matrix[i, z + 1];
                matrix[i, z + 1] = temp;
            }
        }
    }
}
}

int a = Input("Введите количество строк: ");
int b = Input("Введите количество столбцов: ");
int min = Input("Введите минимальное значение диапозона: ");
int max = Input("Введите максимальное значение диапозона: ");
int[,] matrix = CreateArray(a, b);
FillRandommatrix(matrix,min,max);
Console.WriteLine(Print(matrix));
SortRowsOfMatrix(matrix);
Console.WriteLine(Print(matrix));