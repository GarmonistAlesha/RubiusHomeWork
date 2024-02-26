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
        var PushForTest = new Stack<int>();
        int Push = PushForTest.Count;
        PushForTest.Push(1);
        int PushForTest2 = PushForTest.Count;
        Assert.Equal(++Push, PushForTest2);

    }
    [Fact]
    public void PopTest()
    {
        var PopForTest = new Stack<int>();
        PopForTest.Push(6);
        PopForTest.Push(7);
        int LengthOfStack = PopForTest.Count;
        PopForTest.Pop();
        int NewLengthOfStack = PopForTest.Count;
        Assert.Equal(NewLengthOfStack, LengthOfStack - 1);
    }

}
