namespace TestMatrix;
using Matrix;
public class Tests
{
    [Test]
    public void TestFindSumBetweenMinAndMax()
    {
       
        int[,] matrix = {
            {1,  2,  3,  4,  5},
            {6,  7,  8,  9,  10},
            {11, 12, 13, 14, 15},
            {16, 17, 18, 19, 20},
            {21, 22, 23, 24, 25}
        };
        int expected = 325;
        
        int result = Matrix.FindSumBetweenMinAndMax(matrix);

        
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void TestFindSumBetweenMinAndMax_AllNegativeNumbers()
    {
        
        int[,] matrix = {
            {-1, -2, -3},
            {-4, -5, -6},
            {-7, -8, -9}
        };
        int expected = -45; // Сумма элементов между минимальным и максимальным элементами

        
        int result = Matrix.FindSumBetweenMinAndMax(matrix);

       
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void TestFindSumBetweenMinAndMax_AllSameNumbers()
    {
        
        int[,] matrix = {
            {2, 2, 2},
            {2, 2, 2},
            {2, 2, 2}
        };
        int expected = 20;

        
        int result = Matrix.FindSumBetweenMinAndMax(matrix);

        
        Assert.AreEqual(expected, result);
    }
}