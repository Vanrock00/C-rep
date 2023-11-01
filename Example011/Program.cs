// string[,] table = new string [2,5];
// table[1,2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

void PrintMatrix(int[,] matrix) // Вывод матрицы
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    Console.Write($"{matrix[rows, columns]} ");
                }
            Console.WriteLine();
        } 
}

void FillMatrix(int[,] matrix) // Заполнени матрицы случайными числами
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10); // (1; 10]
        }
    }
}

int[,] matrix = new int [3, 4];

PrintMatrix(matrix);
FillMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);