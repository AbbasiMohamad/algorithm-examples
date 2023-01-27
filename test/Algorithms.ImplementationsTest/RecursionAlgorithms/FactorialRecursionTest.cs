using Algorithms.Implementations.RecursionAlgorithms;

namespace Algorithms.ImplementationsTest.RecursionAlgorithms;

public class FactorialRecursionTest
{
    [Theory]
    [InlineData(5, 120)]
    [InlineData(6, 720)]
    [InlineData(10, 3_628_800)]
    public void test_factorial_calculation(int factor, int expectedResult)
    {
        var mut = new FactorialRecursion();
        var actualResult = mut.CalculateFactorial(factor);
        Assert.Equal(expectedResult, actualResult);
    }
}
