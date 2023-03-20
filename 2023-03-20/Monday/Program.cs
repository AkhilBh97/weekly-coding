public class Program
{
    public static void Main()
    {
        //CheckEquality(1, true) -> false
        var ceIB = CheckEquality(1, true);
        Console.WriteLine($"(1, true) => {ceIB}");
        //CheckEquality(0, "0") -> false
        var ceIS = CheckEquality(0, "0");
        Console.WriteLine($"(0, \"0\") => {ceIS}");
        //CheckEquality(1,  1) -> true
        var ceII = CheckEquality(1, 1);
        Console.WriteLine($"(1, 1) => {ceII}");
    }

    public static bool CheckEquality<T, U>(T a, U b){
        //check type equality
        if (a.GetType() != b.GetType()) return false;
        return a.Equals(b);
    }
}