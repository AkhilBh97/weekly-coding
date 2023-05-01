
namespace Monday;
public class Program
{
    public static void Main(string[] args){
        int n = Int32.Parse(args[0]);
        Console.WriteLine($"collatz({n}) => {collatz(n)}");
    }

    // * Return the number of moves to 1 for the pattern:
    // if n is odd: n -> 3n+1
    // else:        n -> n/2
    public static int collatz(int n, int steps=0){
        if (n==1) return steps;

        if (n%2==0) n/=2;
        else n = n*3+1;

        return collatz(n, steps+1);
    }
}