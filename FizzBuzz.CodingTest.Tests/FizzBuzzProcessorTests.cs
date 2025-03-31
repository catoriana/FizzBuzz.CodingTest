using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.CodingTest.Tests;

public class FizzBuzzProcessorTests
{
    private readonly IFizzBuzzProcessor _processor;

    public FizzBuzzProcessorTests()
    {
        _processor = new FizzBuzzProcessor();
    }

    [Fact]
    public void GetEvaluators_WhenCalled_Returns_ListOfFizzBuzzEvaluators()
    {
        // Act
        var result = _processor.GetEvaluators();

        Assert.NotNull(result);
        Assert.Contains(result, x => x.GetType() == typeof(FizzEvaluator));
        Assert.Contains(result, x => x.GetType() == typeof(BuzzEvaluator));
        Assert.Contains(result, x => x.GetType() == typeof(FizzBuzzEvaluator));
        Assert.Contains(result, x => x.GetType() == typeof(NumberEvaluator));
    }

    [Theory]
    [InlineData(1, 15, "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz")]
    public void Process_WhenCalled_Returns_ExpectedResult(int startRange, int endRange, string expectedResult)
    {
        // Act
        var result = _processor.Process(startRange, endRange);

        // Assert
        Assert.Equal(result, expectedResult);
    }
}
