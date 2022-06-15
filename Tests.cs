using Xunit;

public class StringDecodeTests
{
    [Theory]
    [InlineData("1", 1)] // a
    [InlineData("99", 1)] // ii
    [InlineData("10", 1)] // j
    [InlineData("11", 2)] // aa, k
    [InlineData("123", 3)] // abc, aw, lc
    [InlineData("1212", 5)] // abab, abl, aub, lab, ll
    // Bonus: Please add more tests for other interesting cases
    [InlineData("", 1)]
    [InlineData("0", 0)]
    [InlineData("1203", 1)]
    public void CountTest(string encoded, int expectedCount)
    {
        Assert.Equal(expectedCount, StringDecode.CountDecodings(encoded));
    }
}