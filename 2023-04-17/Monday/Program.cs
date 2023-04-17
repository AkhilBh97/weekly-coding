namespace Monday_2023_04_17;
public class Program
{
    // ! Run the program and add the string as an argument
    public static void Main(string[] args){
        string input = args[0];
        int[] indices = IndexOfCapitals(input);
        int n = indices.Length;
        Console.Write("[");
        for(int i=0; i<n; i++){
            Console.Write($"{indices[i]}");
            if (i<n-1) Console.Write(", ");
        }
        Console.Write("]");
    }

    // * Takes a string, returns an ordered array with the indices of all capital letters 
    public static int[] IndexOfCapitals(string s){
        int n = s.Count();
        List<int> indices = new();
        for (int i=0; i<n; i++){
            if (Char.IsUpper(s[i])) indices.Add(i);
        }
        return indices.ToArray<int>();
    }
}