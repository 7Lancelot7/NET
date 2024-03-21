namespace TestReverseNumber;

public class Tests
{
    [Test]
    public void TestReverseNumber()
    {
        string number = "12345";


        string result = ReverseNumber.Reverse(number);


        Assert.AreEqual("54321", result);
    }

    [Test]
    public void TestReverseEmptyString()
    {
        string number = "";


        string result = ReverseNumber.Reverse(number);


        Assert.AreEqual("", result);
    }

    [Test]
    public void TestReverseSingleDigit()
    {
        string number = "7";
        string expected = "7";


        string result = ReverseNumber.Reverse(number);


        Assert.AreEqual(expected, result);
    }

    [Test]
    public void TestReverseNullString()
    {
        Assert.Throws<NullReferenceException>(() => ReverseNumber.Reverse(null));
    }
}