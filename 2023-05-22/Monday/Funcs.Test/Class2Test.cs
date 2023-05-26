namespace Funcs.Test;

public class Class2Test
{
    [Fact]
    public void SumDigitsReturnsSum(){
        //ARRANGE
        string text = "ab1231da";

        //ACT
        var result = Class2.sumDigits(text);

        //ASSERT
        Assert.IsType<int>(result);
        Assert.Equal(7, result);
    }

    [Fact]
    public void SumDigitsReturnsZero(){
        //ARRANGE
        string text = "abcde";

        //ACT
        var result = Class2.sumDigits(text);

        //ASSERT
        Assert.Equal(0, result);
    }
}