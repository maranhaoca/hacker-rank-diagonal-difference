using Xunit;
using Src;
using System.Collections.Generic;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        var arr = new List<List<int>>{
            new List<int>{1, 2, 3},
            new List<int>{4, 5, 6},
            new List<int>{9, 8, 9}
        };
        var expected = 2;

        var actual = Result.diagonalDifference(arr);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var arr = new List<List<int>>{
            new List<int>{11, 2, 4},
            new List<int>{4, 5, 6},
            new List<int>{10, 8, -12}
        };
        var expected = 15;

        var actual = Result.diagonalDifference(arr);

        Assert.Equal(expected, actual);
    }
}