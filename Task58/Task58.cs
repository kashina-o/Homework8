// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

void ProductOfMatrices(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
{ 
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
    int sum = 0;
    for (int k = 0; k < matrix1.GetLength(1); k++)
    {
        sum += matrix1[i,k] * matrix2[k,j];
    }
        resultMatrix[i,j] = sum;
    }
}
}

int rows = Input("Введите количество строк: ");
int columns = Input("Введите количество столбцов: ");
int min = Input("Введите минимальное значение диапозона: ");
int max = Input("Введите максимальное значение диапозона: ");
int[,] firstMatrix = CreateArray(rows, columns);
int[,] secondMatrix = CreateArray(rows, columns);
int[,] resultMatrix = CreateArray(rows, columns);
FillRandommatrix(firstMatrix,min,max);
FillRandommatrix(secondMatrix,min,max);
Console.WriteLine(Print(firstMatrix));
Console.WriteLine(Print(secondMatrix));
ProductOfMatrices(firstMatrix, secondMatrix,resultMatrix);
Console.WriteLine("Произведение двух матриц:");
Console.WriteLine(Print(resultMatrix));