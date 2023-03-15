public class Program
{
    public static void Main(string[] args){
        int a = Int32.Parse(args[0]);
        int b = Int32.Parse(args[1]);
        //dotnet run <a> <b>
        Console.WriteLine($"{a} + {b} = {Sum(a,b)}");
    }

    public static int Sum(int a, int b){
        return a + b;
    }
}