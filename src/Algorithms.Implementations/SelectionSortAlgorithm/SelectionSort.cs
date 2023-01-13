namespace Algorithms.Implementations.SelectionSortAlgorithm;

public class SelectionSort
{

    public int[] SortBySelection(int[] arrays)
    {
        int[] newarray = new int[arrays.Length];
        
        for (int i=0; i < newarray.Length; i++)
        {
            newarray[i] = FindSmallest(arrays);
            int index = Array.IndexOf(arrays, newarray[i]);
            arrays = arrays.Where((val, i) => i != index).ToArray();
        }
        return newarray;
    }

    // [4,7,2,8]
    private int FindSmallest(int[] array)
    {
        int lowestValue = array[0];
        for (int i=0; i < array.Length; i++)
        {
            if (lowestValue > array[i])
            {
                lowestValue = array[i];
            }
        }
        return lowestValue;
    }
}
