// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rows = ReadInt("Введите колличество строк: ");
int cols = ReadInt("Введите колличество столбцов: ");
int[,] matrix = FillMatrix(rows, cols, 0, 9);
PrintMatrix(matrix);
NewMatrix(matrix);
Printnewmatrix(matrix);
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
}
void NewMatrix(int[,] newmatrix)
{
    for (int i = 0; i < newmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newmatrix.GetLength(1); j++)
        {

            for (int min = 0; min < newmatrix.GetLength(1) - 1; min++)
            {
                if (newmatrix[i, min] < newmatrix[i, min + 1])

                {
                    int temp = newmatrix[i, min + 1];
                    newmatrix[i, min + 1] = newmatrix[i, min];
                    newmatrix[i, min] = temp;
                }
            }
        }

    }
    System.Console.WriteLine();
}

void Printnewmatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

