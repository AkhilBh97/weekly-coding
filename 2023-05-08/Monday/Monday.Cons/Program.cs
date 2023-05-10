using Monday.Funcs;
using System.Text;
namespace Monday.Cons;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Example for Median of Two Sorted Arrays");
        Console.WriteLine("Enter the length of array 1:");
        int len1 = Int32.Parse(Console.ReadLine()!);
        int[] nums1 = new int[len1];
        Console.WriteLine($"Enter {len1} values for array 1:");
        for (int i = 0; i < len1; i++)
        {
            nums1[i] = Int32.Parse(Console.ReadLine()!);
        }
        Console.WriteLine("Enter the length of array 2:");
        int len2 = Int32.Parse(Console.ReadLine()!);
        int[] nums2 = new int[len2];
        Console.WriteLine($"Enter {len2} values for array 1:");
        for (int i = 0; i < len2; i++)
        {
            nums2[i] = Int32.Parse(Console.ReadLine()!);
        }

        var median = Class1.GetMedian(nums1, nums2);
        Console.WriteLine($"Input: {ArrToString("nums1", nums1)}, {ArrToString("nums2", nums2)}");
        Console.WriteLine($"Output: {median}");

        Console.WriteLine("\nExample for MergeK");
        LinkedList<LinkedList<int>> biglist = new();
        Console.WriteLine("Enter the number of linked lists to merge");
        len1 = Int32.Parse(Console.ReadLine()!);
        for (int i=0; i<len1; i++){
            LinkedList<int> nestedlist = new();
            Console.WriteLine($"Enter the length for List #{i}:");
            len2 = Int32.Parse(Console.ReadLine()!);
            Console.WriteLine($"Enter the numbers for List #{i} in ascending order:");
            for(int j=0; j<len2; j++){
                nestedlist.AddLast(Int32.Parse(Console.ReadLine()!));
            }
            biglist.AddLast(nestedlist);
        }

        Console.WriteLine($"Input =\n{NestedListToString<LinkedList<LinkedList<int>>, LinkedList<int>, int>(biglist)}");

        var mergedlist = Class2.MergeK(biglist);
        Console.WriteLine($"Output = {ListToString<LinkedList<int>, int>(mergedlist!)}");
    }

    private static string ArrToString<T>(string name, T[] arr)
    {
        StringBuilder sb = new();
        sb.Append("[");
        foreach (T t in arr)
        {
            sb.Append($"{t}");
            if (!t!.Equals(arr[arr.Length - 1])) sb.Append(", ");
        }
        sb.Append("]");
        return sb.ToString();
    }

    private static string ListToString<TEnum, T>(TEnum list)
        where TEnum : IEnumerable<T>
    {
        StringBuilder sb = new();
        sb.Append($"[");
        var iter = list.GetEnumerator();
        while(true){
            if (iter.MoveNext()) sb.Append($"{iter.Current}");
            else break;
            if (!iter.Current!.Equals(list.Last())) sb.Append(" => ");
        }
        sb.Append("]");
        return sb.ToString();
    }

    private static string NestedListToString<TEnum, TNestedEnum, T>(TEnum list)
        where TEnum : IEnumerable<TNestedEnum>
        where TNestedEnum : IEnumerable<T>
    {
        StringBuilder sb = new();
        sb.Append("[");
        var iter = list.GetEnumerator();
        while(true){
            if (iter.MoveNext()) sb.Append(ListToString<TNestedEnum, T>(iter.Current));
            else break;
            if (!iter.Current.Equals(list.Last())) sb.Append(" =>\n");
        }
        sb.Append("]");
        return sb.ToString();
    }
}