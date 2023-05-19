namespace Funcs;

public static class Class2
{

    //If a linked list is circular, there is a point where one node refers to another in the list
    // ! For the purpose of simplicity, let's assume that all the values in the list are unique
    // ! This makes it so Find() will not run into any issues of duplicates
    // ! We should also assume that the list is both non-empty and has at least 2 nodes
    public static LinkedListNode<T>? FindCorruptNode<T>(this LinkedList<T> list){
        HashSet<T> values = new();
        var iterator = list.GetEnumerator();
        iterator.MoveNext(); //starting at the first node in the list
        while(iterator.MoveNext()){
            //if the value of the current node is in the set, return the node with that value
            var current = iterator.Current;
            if (values.Contains(current)) return list.Find(current)!;

            values.Add(current);
        }

        //went through the entire list without a cycle, so return a null
        return null;
    }
}