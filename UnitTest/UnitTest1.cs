namespace UnitTest;
using NUnit.Framework;
using Calculator;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AdditionTest()
    {
        Assert.That(5 == Calculator.Add(2, 3), Is.True);
    }
    
    [Test]
    public void SubtractionTest()
    {
        Assert.That(2 == Calculator.Subtract(5, 3), Is.True);
    }
    
    [Test]
    public void MultiplyTest()
    {
        Assert.That(360 == Calculator.Multiply(120, 3), Is.True);
    }
    
    [Test]
    public void DivideTest()
    {
        Assert.That(100 == Calculator.Divide(500, 5), Is.True);
    }
    
    [Test]
    public void DivideByZeroTest()
    {
        Assert.Throws<DivideByZeroException>(() => Calculator.Divide(99, 0));
    }
    
    [Test]
    public void AdditionFailureTest()
    {
        Assert.That(50 == Calculator.Add(40, 5), Is.True);
    }
}