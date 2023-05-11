namespace Monday.Funcs;


public static class Class2
{
    // ! Assumptions
    // * All k linked lists are sorted
    public static LinkedList<T>? MergeK<T>(LinkedList<LinkedList<T>> list)
        where T : IComparable
    {
        // Merge process goes through all n lists in the main list
        // Every operation reduces the list's size by 1, until only 1 list remains
        // Time complexity is O(log(n))

        // While there are at least 2 internal linked lists:
        // Remove the first two, merge them, then add it back to the main list
        while (list.Count > 1)
        {
            //Pop the first two lists
            var l1 = list.First!.Value;
            list.RemoveFirst();
            var l2 = list.First!.Value;
            list.RemoveFirst();
            //Merge them
            var merged = Merge(l1!, l2!);
            //add the merged list back
            list.AddLast(merged);
        }

        return list.First!.Value;
    }

    //Merge two sorted Linked Lists, return the merged list
    // Peek at the first value in each list
    // Add the lowest to a new list, then remove it from its source
    // Repeat until both source lists are empty
    private static LinkedList<T> Merge<T>(LinkedList<T> A, LinkedList<T> B)
        where T : IComparable
    {
        LinkedList<T> temp = new();
        while (A.Count>0 && B.Count>0)
        {
            var a = A.First!.Value;
            var b = B.First!.Value;
            //Add the node with the lower value to temp, and pop it from the list
            if (a.CompareTo(b) < 0)
            {
                temp.AddLast(a);
                A.RemoveFirst();
            }
            else
            {
                temp.AddLast(b);
                B.RemoveFirst();
            }
        }

        //If either list had more, pop and add it to the temp list
        while(A.Count>0){
            temp.AddLast(A.First!.Value);
            A.RemoveFirst();
        }

        while(B.Count>0){
            temp.AddLast(B.First!.Value);
            B.RemoveFirst();
        }

        return temp;
    }
}