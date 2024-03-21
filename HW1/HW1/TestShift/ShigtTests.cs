namespace ShiftTests;

public class Tests
{
    [TestCase(12345, 3, ExpectedResult = 98760)]
    [TestCase(123, 3, ExpectedResult = 984)]
    [TestCase(123, 1, ExpectedResult = 246)]
    [TestCase(123, 6, ExpectedResult = 7872)] // Циклічний зсув на 6 розрядів те ж саме, що Циклічний зсув на 3 розряди
    public int TestLeftShift(int number, int shift)
    {
        return Shift.Shift.LeftShift(number, shift);
    }
}