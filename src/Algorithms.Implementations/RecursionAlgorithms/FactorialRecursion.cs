namespace Algorithms.Implementations.RecursionAlgorithms;
public class FactorialRecursion
{


    public long CalculateFactorial(int factor)
    {
        if (factor == 0) return 1;
        var result =+ factor * CalculateFactorial(factor - 1);
        return result;
    }
}
