using DSA.Leetcode;

namespace LCTests;



public class TrapWaterTests
{
    private readonly TrapWater _sut;

    public TrapWaterTests()
    {
        _sut = new TrapWater();
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void TrapWater(int expected, int[] nums)
    {
        Assert.Equal(expected, _sut.TrapWaters(nums));
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return new object[] { 6, new int[] { 0,1,0,2,1,0,1,3,2,1,2,1 } };
        yield return new object[] { 9, new int[] { 4,2,0,3,2,5 }};
        yield return new object[] { 1, new int[] { 1, 0, 2 } };
    }
}