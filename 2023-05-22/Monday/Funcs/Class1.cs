namespace Funcs;
public static class Class1
{
    // ! T must be some form of signed number, and must be capable of comparisons
    public static T[] SecondHighests<T>(IEnumerable<T[]> sets)
        where T : System.Numerics.ISignedNumber<T>, IComparable<T>
    {
        List<T> secondhighests = new();
        foreach(var set in sets){
            //for each triple, we'll sort it 
            Array.Sort(set);
            //then add the 2nd-highest to the list
            secondhighests.Add(set[set.Length-2]);
        }

        return secondhighests.ToArray();
    }
}
