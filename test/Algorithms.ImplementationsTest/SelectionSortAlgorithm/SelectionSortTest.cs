using Algorithms.Implementations.BinarySearchAlgorithm;
using Algorithms.Implementations.SelectionSortAlgorithm;

namespace Algorithms.ImplementationsTest.BinarySearchAlgorithm;

public class SelectionSortTest
{

    [Theory]
    [InlineData(new[] { 7, 2, 6, 4, 5, 3, 1, 8 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
    [InlineData(new[] { 1, 19, 6, 28, 11, 16, 4, 7 }, new[] { 1, 4, 6, 7, 11, 16, 19, 28 })]
    [InlineData(new[] { 28, 1, 4, 6, 7, 11, 16, 19 }, new[] { 1, 4, 6, 7, 11, 16, 19, 28 })]
    [InlineData(new[] { 28, 1, -4, 6, 7, -11, 16, -19 }, new[] { -19, -11, -4, 1, 6, 7, 16, 28 })]
    public void test_selection_sort(int[] array, int[] sortedArray)
    {
        var mut = new SelectionSort();
        var actualResult = mut.SortBySelection(array);
        Assert.Equal(sortedArray, actualResult);
    }
}
