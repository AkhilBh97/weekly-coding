namespace Funcs;

public static class Class2
{
    public static int sumDigits(string text){
        int sum = 0;
        foreach(char c in text){
            if (Char.IsDigit(c)) {
                int num = int.Parse($"{c}");
                sum += num;
            }
        }

        return sum;
    }
}