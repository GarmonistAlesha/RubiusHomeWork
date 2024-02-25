using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Xunit;
using Xunit.Abstractions;

namespace Lession6.Tests;


public class UnitTests1
{
    [Fact]
    public void PushTest()
    {
        var TestStackPush = new Stack<int>();
        int StackPush = TestStackPush.Count;
        var Element = 1;
        TestStackPush.Push(Element);
        int NewLengthOfStack = TestStackPush.Count;
        Assert.Equal(NewLengthOfStack, StackPush + 1);
    }
    [Fact]
    public void PopTest()
    {
        var TestStackPop = new Stack<int>();
        TestStackPop.Push(5);
        TestStackPop.Push(3);
        int StackPop = TestStackPop.Count;
        TestStackPop.Pop();
        int NewLengthOfStack = TestStackPop.Count;
        Assert.Equal(StackPop, StackPop - 1);
    }


}
