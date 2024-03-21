namespace HW1;

public static class FactorialClass
{
    public static long Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Number of Factorial must be greater than 0 ");
        }

        if (number == 0)
        {
            return 1;
        }
        if (number == 1)
        {
            return number;
        }

        return number * Factorial(number - 1);
    }
}