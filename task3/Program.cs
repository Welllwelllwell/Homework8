// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int rows = ReadInt("Введите колличество строк: ");
int cols = ReadInt("Введите колличество столбцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 9);
int[,] secondmatrix = SecondFillMatrix(rows, cols, 0, 9);
int[,] compmatrix = Compmatrix(rows, cols);
PrintMatrix(matrix);
PrintSecondMatrix(secondmatrix);
Compmatrix(compmatrix);

//------------------------------
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}
void PrintMatrix(int[,] matrixPrint)
{
    for (int i = 0; i < matrixPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixPrint[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] SecondFillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}
void PrintSecondMatrix(int[,] secondmatrix)
{
    for (int i = 0; i < secondmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondmatrix.GetLength(1); j++)
        {
            System.Console.Write(secondmatrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void Compmatrix(int[,] compmatrix)
{
   if (matrix.GetLength(0) != secondmatrix.GetLength(1))
{
    Console.WriteLine(" умножить нельзя");
    return;
}
for (int i = 0; i< matrix.GetLength(0); i++)
{
    for (int j = 0; j < secondmatrix.GetLength(1); j++)
    {
        compmatrix[i, j] = 0;
        for (int k = 0; k <matrix.GetLength(1); k++)
        {
            compmatrix[i, j] += matrix[i, k] * secondmatrix[k, j];
        }
        System.Console.WriteLine(compmatrix[i,j]);
    }
}
}