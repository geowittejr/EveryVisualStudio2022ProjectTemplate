using NUnit.Framework;

namespace Tests;

public class NUnit3TestItem
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}
