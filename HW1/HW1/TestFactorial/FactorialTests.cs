using HW1;

namespace TestFactorial;

public class Tests
{
    [Test]
    public void TestFactorialOfPositiveNumber1()
    {
        var result = FactorialClass.Factorial(5);
        Assert.AreEqual(120, result);
    }
    [Test]
    public void TestFactorialOfZero()
    {
        var result = FactorialClass.Factorial(0);
        Assert.AreEqual(1, result);
    }

    [Test]
   
    public void TestFactorialOfNegativeNumber()
    {
        Assert.Throws<ArgumentException>(()=>FactorialClass.Factorial(-1));
    }
    
    [Test]
    public void TestFactorialOfPositiveNumber2()
    {
        
        var result = FactorialClass.Factorial(7);
        Assert.AreEqual(5040, result);
    }
    
    [Test]
    public void TestFactorialOfPositiveNumber3()
    {
        
        var result = FactorialClass.Factorial(10);
        Assert.AreEqual(3628800, result);
    }
    
    [Test]
    public void TestFactorialOfPositiveNumber4()
    {
        
        var result = FactorialClass.Factorial(15);
        Assert.AreEqual(1307674368000, result);
    }
}