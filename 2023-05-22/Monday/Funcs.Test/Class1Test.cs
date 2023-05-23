namespace Funcs.Test;

public class Class1Test
{
    [Fact]
    public void SecondHighestsReturnsNumberArray()
    {
        //ARRANGE 
        List<int[]> triples = new();
        triples.Add(new int[] {10,20,30});
        triples.Add(new int[] {4,3,6});
        triples.Add(new int[] {111,222,55});

        //ACT
        var result = Class1.SecondHighests(triples);

        //ASSERT
        Assert.IsType<Int32[]>(result);
        Assert.Equal(3, result.Length);
        Assert.True(Enumerable.SequenceEqual(new int[] {20,4,111}, result));
    }
}