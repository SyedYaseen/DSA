namespace LCTests;



public class InsertPosTests
{
    private readonly InsertPosition _sut;

    public InsertPosTests()
    {
        _sut = new InsertPosition();
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void InsertPos(int expected, int[] nums, int target)
    {
        Assert.Equal(expected, _sut.InsertPos(nums, target));
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return new object[] { 0, new int[] { 2, 3, 4 }, 1 };
        yield return new object[] { 1, new int[] { 2, 3, 4 }, 3 };
        yield return new object[] { 3, new int[] { 2, 3, 4, 7, 8 }, 5 };
        yield return new object[] { 3, new int[] { 2, 3, 4, 6, 8 }, 5 };
        yield return new object[] { 0, new int[] { 1 }, 1 };
    }
}