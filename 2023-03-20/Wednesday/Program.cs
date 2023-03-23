public class Program
{
    public static void Main(string[] args){
        int v = Int32.Parse(args[0]);
        int c = Int32.Parse(args[1]);
        Console.WriteLine($"Voltage: {v}\nCurrent: {c}\nPower: {CircuitPower(v,c)}");
    }

    public static int CircuitPower(int v, int c){
        return v * c;
    }
}