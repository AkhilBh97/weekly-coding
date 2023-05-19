namespace Funcs;

public class SinglyLinkedList<T>
{
    public Node? First {get; set;}
    public Node? Last {get; set;}
    public int Count {get; set;} = 0;
    public class Node
    {
        public T? Value {get; set;}
        public Node? Next {get;set;}

        public bool RefEquals(Node other){
            return (this.Value!.Equals(other.Value) && this.Next!.Value!.Equals(other.Next!.Value));
        }
    }

    //add after the last node
    public void Add(T value){
        Node n = new();
        n.Value = value;
        //if the list is empty, this will be the first and only node
        if (this.IsEmpty()) {
            First = n;
            Last = n;
        }
        //otherwise set the Last reference to the new node, then set Last to the node
        else {
            Last!.Next = n;
            Last = n;
        }

        Count++;
    }

    //if the first node is null, assume the list is empty
    public bool IsEmpty(){
        return First is null;
    }

    public Node[] ToArray(){
        Node[] array = new Node[Count];
        Node current = First!;
        int index = 0;
        while(current!.Next is not null){
            array[index++] = current;
            current = current.Next;
        }
        array[index] = Last!;

        return array;
    }

    // ! For the purpose of this, we don't need any other functions other than just adding
}