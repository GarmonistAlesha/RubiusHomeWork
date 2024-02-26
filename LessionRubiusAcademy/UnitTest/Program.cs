using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Xunit;
using Xunit.Abstractions;



public class TestStack
{
    [Fact]
    public void TestPop()
    {
        var stack = new Stack();
        {
            stack.Push(5);
            stack.Push(10);
        }

        var push = stack.Pop();
        Assert.Equal(10, push);
    }
}
