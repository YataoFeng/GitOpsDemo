namespace WebApplication.Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Console.WriteLine("Hello CI !!!!!!!!!!!!!!!!!!!!");
        Assert.IsTrue(Ok.Value());
    }
}