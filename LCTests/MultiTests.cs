using DSA.Leetcode;

namespace LCTests;



public class MultiTests
{
    private readonly Multi _sut;

    public MultiTests()
    {
        _sut = new Multi();
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void InsertPos(String expected, String num1, String num2)
    {
        Assert.Equal(expected, _sut.Multip(num1, num2));
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return new object[] { "56088", "123", "456" };
        yield return new object[] { "6", "2", "3" };
    }
}