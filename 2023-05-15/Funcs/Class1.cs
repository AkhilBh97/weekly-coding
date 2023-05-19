namespace Funcs;

public static class Class1
{
    /*
    Given two (singly) linked lists, determine if the two lists intersect, return the intersecting node. 
    Note that the intersection is defined based on reference, not value. 
    If the kth node of the first linked list is the same node as the jth node of the second linked list, then they are intersecting.

    This of course can't be done in C# since the Nodes keep track of which list they're in, so we'll have to make a new 
        collection type
    */
    public static SinglyLinkedList<T>.Node? DoesIntersect<T>(SinglyLinkedList<T> listA, SinglyLinkedList<T> listB)
    {
        //normally we could just use LINQ to fetch a specific node but we'll have to iterate manually
        var arrayA = listA.ToArray();
        var arrayB = listB.ToArray();

        foreach (var a in arrayA){
            foreach(var b in arrayB){
                if (a.RefEquals(b)) return a;
            }
        }

        //no intersecting nodes found, return null
        return null;
    }
}
