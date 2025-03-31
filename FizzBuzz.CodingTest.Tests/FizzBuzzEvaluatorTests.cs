using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.CodingTest.Tests;

public class FizzBuzzEvaluatorTests
{
    private readonly IFizzBuzzEvaluator _evaluator;

    public FizzBuzzEvaluatorTests()
    {
        _evaluator = new FizzBuzzEvaluator();
    }

    [Theory]
    [InlineData(15, true)]
    [InlineData(3, false)]
    [InlineData(5, false)]
    [InlineData(2, false)]
    public void CheckFizzBuzz_ShouldReturnFizzBuzz_WhenDivisibleBy3And5(int number, bool expectedResult)
    {
        // Arrange
        var outputMessage = "FizzBuzz";

        // Act
        bool result = _evaluator.CheckFizzBuzz(number);

        // Assert
        Assert.Equal(expectedResult, result);
        Assert.Equal(outputMessage, _evaluator.OutputMessage);
    }
}
