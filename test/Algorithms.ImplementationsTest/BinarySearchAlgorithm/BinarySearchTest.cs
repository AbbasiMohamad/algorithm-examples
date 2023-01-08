using Algorithms.Implementations.BinarySearchAlgorithm;

namespace Algorithms.ImplementationsTest.BinarySearchAlgorithm;

public class BinarySearchTest
{

    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 5, 4)]
    [InlineData(new[] { 1, 4, 6, 7, 11, 16, 19, 28 }, 19, 6)]
    [InlineData(new[] { 1, 4, 6, 7, 11, 16, 19, 28 }, 30, null)]
    public void test_in_binary_search(int[] sortedList, int targetItem, int? expectedResult)
    {
        var mut = new BinarySearch();
        var actualResult = mut.SearchByBinary(sortedList, targetItem);
        Assert.Equal(expectedResult, actualResult);
    }
}
