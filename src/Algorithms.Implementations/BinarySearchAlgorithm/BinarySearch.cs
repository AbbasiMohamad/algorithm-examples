namespace Algorithms.Implementations.BinarySearchAlgorithm;
public class BinarySearch
{

    public int? SearchByBinary(int[] sortedList, int item)
    {
        int low = 0;
        int high = sortedList.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (sortedList[mid] == item) return mid;
            if (sortedList[mid] < item) low = mid + 1;
            else high = mid - 1;
        }
        return null;
    }
}
