namespace Matrix;

public static class Matrix
{
    public static int FindSumBetweenMinAndMax(int[,] matrix)
    {
        int min = matrix[0, 0];
        int max = matrix[0, 0];
        int Xmin = 0, Ymin = 0, Xmax = 0, Ymax = 0;
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                    Xmin = j;
                    Ymin = i;
                }

                if (matrix[i, j] >= max)
                {
                    max = matrix[i, j];
                    Xmax = j;
                    Ymax = i;
                }
            }
        }

        int startRow = Math.Min(Ymin, Ymax);
        int endRow = Math.Max(Ymin, Ymax) + 1;
        int startCol = Math.Min(Xmin, Xmax);
        int endCol = Math.Max(Xmin, Xmax) + 1;

        for (int i = startRow; i < endRow; i++)
        {
            if (i == startRow)
            {
                for (int j = startCol; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }

            else if (i == endRow)
            {
                for (int j = 0; j < endCol; j++)
                {
                    sum += matrix[i, j];
                }
            }
            else
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
        }

        return sum;
    }
}