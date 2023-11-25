using DSA.Leetcode;

namespace LCTests;



public class FirstOccurenceTests
{
    private readonly FirstOccurence _sut;

    public FirstOccurenceTests()
    {
        _sut = new FirstOccurence();
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void InsertPos(int expected, string haystack, string needle)
    {
        Assert.Equal(expected, _sut.FirstOccur(haystack, needle));
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return new object[] { 0, "sadbutsad", "sad" };
        yield return new object[] { -1,"leetcode", "leeto" };
        yield return new object[] { 3, "abcleetadas" , "leet" };
    }
}