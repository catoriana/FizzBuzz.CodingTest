using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.CodingTest.Tests;

public class BuzzEvaluatorTests
{
    private readonly IFizzBuzzEvaluator _evaluator;

    public BuzzEvaluatorTests()
    {
        _evaluator = new BuzzEvaluator();
    }

    [Theory]
    [InlineData(5, true)]
    [InlineData(3, false)]
    [InlineData(2, false)]
    [InlineData(15, false)]
    public void CheckFizzBuzz_ShouldReturnBuzz_WhenDivisibleBy5Only(int number, bool expectedResult)
    {
        // Arrange
        var outputMessage = "Buzz";

        // Act
        bool result = _evaluator.CheckFizzBuzz(number);

        // Assert
        Assert.Equal(expectedResult, result);
        Assert.Equal(outputMessage, _evaluator.OutputMessage);
    }
}
